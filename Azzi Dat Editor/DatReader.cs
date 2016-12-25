using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Bibliotecas que eu adicionei
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Azzi_Dat_Editor
{
    /* Cada ReadByte() que aparecer no código, entenda que está sendo lido
     * um conjunto de 8 bits do arquivo dat, por exemplo 0101 1010, as comparações
     * de bytes (conjunto de 8 bits) são feitas em hexadecimal, por exemplo 0x1A.
     * 
     * Cada vez que ReadByte() é acionado, 8 bits são lidos e pulados, dessa forma, a proxima
     * vez que eu acionar ReadByte(), a linguagem irá ler os 8 bits seguintes, e assim em
     * diante até que o arquivo todo seja lido.
     * 
     * ReadUInt16 = lê 16 bits
     * ReadUInt32 = lê 32 bits
     * 
     * -------------------------------------------------------------------------------------
     * 
     * Cada byte lido representa uma coisa das configurações de como as sprites devem se
     * comportar no jogo, por exemplo: 0000 0000 é referencia de um chão, os bytes seguintes
     * são outras configurações do item, até chegar em 1111 1111, isso quer dizer que agora
     * ele vai começar a identificar as sprites do item, primeiro algumas variaveis são dadas
     * para se conhecer o número de sprites do DatItem, com esses valores é possível saber quando
     * as sprites terminarm e assim começa um novo DatItem. Cada identificação de sprite
     * tem o valor de 32 bits
     * 
     */
    /* Em alguns momentos da classe DatReader, você irá encontrar uma função com o nome de AddByte(byte)
     * sendo exercida pelo objeto, para já evitar confusões e facilitar a leitura do código eu vou
     * explicar o que essa função faz: quando eu for gravar o DAT de novo, com as edições feitas, eu
     * não posso simplesmente pegar as informações que eu subi e converter elas para os bytes do DAT
     * porque eu não conheço 100% a estrutura do DAT, então eu não posso gerar um arquivo DAT.
     * Por isso, cada item, tem TODOS os seus bytes salvos em um array (dada vez que AddByte(byte)) é
     * exercida, um novo byte é adicionaro no array, quando preciso pegar uma UInt16 dos bytes, antes de
     * eu pegar essa, eu preciso executar esse comando duas vezes) e assim, quando eu salvar o Tibia.dat
     * eu não gero novos binários, só salvo a alteração daqueles que eu sei qual é o objetivo, e os que
     * eu não sei eu salvo exatamente do jeito que eles são.
     * */
    #region DatReader - classe responsável por ler o arquivo Tibia.dat, retornando um array de objetos DatItem
    class DatReader
    {
        public DatItem[] DatItems;
        public UInt16 numberOfItems, numberOfCreatures, numberOfEffects, numberOfMissiles;
        public bool OpenFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                byte[] subreadbyte = new byte[2]; //Quando eu precisar ler muitos bytes de uma vez (no maximo que eu precisei até agora foram 6)
                BinaryReader readdat = new BinaryReader(File.OpenRead(filepath));
                byte IdOffset = 100; //Onde começa os IDs das coisas
                UInt32 signature = readdat.ReadUInt32(); //assinatura da versão
                numberOfItems = readdat.ReadUInt16(); //Número de itens
                numberOfCreatures = readdat.ReadUInt16(); //Número de criaturas
                numberOfEffects = readdat.ReadUInt16(); //Número de efeitos
                numberOfMissiles = readdat.ReadUInt16(); //Número de misseis (coisas que jogam)
                long numberOfAll = numberOfItems + numberOfCreatures + numberOfEffects + numberOfMissiles - (IdOffset - 1); //quantas coisas tem no total
                uint nIds = IdOffset;
                DatItems = new DatItem[IdOffset + numberOfAll];
                while (nIds < IdOffset + numberOfAll) //O while vai girar até o ultimo item
                {
                    DatItems[nIds] = new DatItem(); //criando o objeto
                    //Definindo se esse objeto é um item, outfit, effect ou missile
                    DatItems[nIds].setWhatIAm(UInt16.Parse(nIds.ToString()), numberOfItems, numberOfCreatures, numberOfEffects);
                    byte readbyte = 0;
                    if (readdat.PeekChar() > -1) { readbyte = readdat.ReadByte(); }
                    else { MessageBox.Show("Cant read all file! "+nIds.ToString()+" items read from " + (numberOfAll + IdOffset).ToString(), "::ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                    //lendo cyte por cyte do baguio até chegar na parte que começa a ver as sprites ;D
                    while (readbyte != 0xFF)
                    {
                        DatItems[nIds].AddByte(readbyte, "att");
                        switch (readbyte)
                        {
                            case 0x00: //ground
                                DatItems[nIds].GroundTile.Is = true;

                                //Lendo e guardando um byte de velocidade
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Lendo e guardando o outro byte
                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                //Convertendo os dois bytes lidos para int
                                DatItems[nIds].GroundTile.Speed = BitConverter.ToUInt16(subreadbyte, 0); //Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());
                                break;

                            case 0x01:
                                DatItems[nIds].TopOrder1 = true;
                                break;

                            case 0x02:
                                DatItems[nIds].TopOrder2 = true;
                                break;

                            case 0x03:
                                DatItems[nIds].TopOrder3 = true;
                                break;

                            case 0x04:
                                DatItems[nIds].IsContainer = true;
                                break;

                            case 0x05:
                                DatItems[nIds].IsStackable = true;
                                break;

                            case 0x06:
                                DatItems[nIds].IsCorpse = true;
                                break;

                            case 0x07:
                                DatItems[nIds].IsUseable = true;
                                break;

                            case 0x08:
                                DatItems[nIds].Writeable.Is = true;

                                //Lendo e guardando um byte de maxlength
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Lendo e guardando o outro byte
                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                //Convertendo os dois bytes lidos para int
                                DatItems[nIds].Writeable.MaxLength = BitConverter.ToUInt16(subreadbyte, 0);
                                break;

                            case 0x09:
                                DatItems[nIds].OnlyReadable.Is = true;

                                //Lendo e guardando um byte de maxlength
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Lendo e guardando o outro byte
                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                //Convertendo os dois bytes lidos para int
                                DatItems[nIds].OnlyReadable.MaxLength = BitConverter.ToUInt16(subreadbyte, 0);
                                break;

                            case 0x0A:
                                DatItems[nIds].IsFluidContainer = true;
                                break;

                            case 0x0B:
                                DatItems[nIds].IsSplash = true;
                                DatItems[nIds].Unknow(readbyte);
                                break;

                            case 0x0C:
                                DatItems[nIds].IsBlocking = true;
                                break;

                            case 0x0D:
                                DatItems[nIds].IsImmobile = true;
                                break;

                            case 0x0E:
                                DatItems[nIds].IsMissileBlocking = true;
                                break;

                            case 0x0F:
                                DatItems[nIds].IsPathBlocking = true;
                                break;

                            case 0x10:
                                
                                DatItems[nIds].IsPickUpAble = true;
                                break;

                            case 0x11:
                                DatItems[nIds].IsHangableOff = true;
                                break;

                            case 0x12:
                                DatItems[nIds].IsHangableHorizontal = true;
                                break;

                            case 0x13:
                                DatItems[nIds].IsHangableVertical = true;
                                break;

                            case 0x14:
                                DatItems[nIds].IsRotatable = true;
                                break;

                            case 0x15:
                                DatItems[nIds].Light.Is = true;

                                //O raio da luz
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                DatItems[nIds].Light.Radius = BitConverter.ToUInt16(subreadbyte, 0);//Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());

                                //A cor da luz
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                DatItems[nIds].Light.Color = BitConverter.ToUInt16(subreadbyte, 0);//Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());
                                break;

                            case 0x16:
                                DatItems[nIds].Unknow(readbyte);
                                //Possível que seja o rotatable
                                break;

                            case 0x17:
                                DatItems[nIds].IsChangeFloor = true;
                                break;

                            case 0x18:
                                DatItems[nIds].Offset.Is = true;

                                //Posição X
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");
                                DatItems[nIds].Offset.X = BitConverter.ToUInt16(subreadbyte, 0);//Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());

                                //Posição Y
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");
                                DatItems[nIds].Offset.Y = BitConverter.ToUInt16(subreadbyte, 0);//Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());
                                break;

                            case 0x19:
                                DatItems[nIds].Raised.Is = true;

                                //Height
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                DatItems[nIds].Raised.Height = BitConverter.ToUInt16(subreadbyte, 0);//Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());
                                break;

                            case 0x1A:
                                DatItems[nIds].IsLayer = true;
                                break;

                            case 0x1B:
                                DatItems[nIds].IsIdleAnimation = true;
                                break;

                            case 0x1C:
                                DatItems[nIds].MiniMap.Is = true;

                                //Height
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                DatItems[nIds].MiniMap.Color = BitConverter.ToUInt16(subreadbyte, 0);//Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());
                                break;

                            case 0x1D:
                                DatItems[nIds].HasHelp.Is = true;
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].HasHelp.setHelpValue(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");
                                if (DatItems[nIds].HasHelp.Value == "Unknow")
                                {
                                    DatItems[nIds].Unknow(subreadbyte[0]); //Um byte desconhecido
                                }
                                break;

                            case 0x1E:
                                DatItems[nIds].isGround = true;
                                break;
                            case 0x1F:
                                DatItems[nIds].Unknow(readbyte);
                                break;
                            case 0x20: //Não sei do que se trata
                                DatItems[nIds].Unknow(readbyte);
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");
                                break;
                            case 0x21: //string
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param"); //item group 1

                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param"); //item group 2

                                //Baguio igual
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Baguio cercado pelos dois iguais (00 normalmente)
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Baguio igual
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Outro 00
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Lendo a length da palavra
                                subreadbyte[0] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[0], "param");
                                subreadbyte[1] = readdat.ReadByte();
                                DatItems[nIds].AddByte(subreadbyte[1], "param");

                                DatItems[nIds].ExtraInfo.Length = BitConverter.ToUInt16(subreadbyte, 0);//Convert.ToUInt16((subreadbyte[0] + subreadbyte[1]).ToString());
                                for (int i = 0; i < DatItems[nIds].ExtraInfo.Length; i++)
                                {
                                    subreadbyte[0] = readdat.ReadByte();
                                    DatItems[nIds].AddByte(subreadbyte[0], "char");
                                    byte[] mychar = new byte[1]; //exigencias toscas do C#, ele só converte um array de bytes para string ¬¬
                                    mychar[0] = subreadbyte[0];
                                    DatItems[nIds].ExtraInfo.Text += Encoding.ASCII.GetString(mychar);
                                }

                                //Um parâmetro 00 que vem depois da palavra (é importante ler para não confundir com Ground)
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Outro 00
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Outro 00
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");

                                //Outro 00
                                subreadbyte[0] = readdat.ReadByte();
                                //DatItems[nIds].Unknow(subreadbyte[0]);
                                DatItems[nIds].AddByte(subreadbyte[0], "param");
                                break;
                            default:
                                DatItems[nIds].Unknow(readbyte);
                                break;
                        }//fim do switch
                        readbyte = readdat.ReadByte(); //Isso aqui é como se fosse um ++ pro WHILE, assim vai até chegar na parte das sprites (FF)
                    }//fim do while, começo das sprites

                    //Adicionando FF ao banco de dados de bytes
                    DatItems[nIds].AddByte(readbyte, "end");

                    //É importante que seja nessa ordem, para quem entende o que está acontecendo ;D
                    // lendo a altura do DatItem
                    readbyte = readdat.ReadByte();
                    DatItems[nIds].AddByte(readbyte, "sprparam");
                    DatItems[nIds].Height = readbyte;

                    // lendo a largura que é medida em sprites
                    readbyte = readdat.ReadByte();
                    DatItems[nIds].AddByte(readbyte, "sprparam");
                    DatItems[nIds].Width = readbyte;

                    //Byte esquisito que vem caso height ou width sejam maiores que 1
                    if (DatItems[nIds].Height > 1 || DatItems[nIds].Width > 1)
                    {
                        readbyte = readdat.ReadByte();
                        DatItems[nIds].AddByte(readbyte, "sprparam");
                        DatItems[nIds].Unknow(readbyte);
                    }

                    //Blendframe
                    readbyte = readdat.ReadByte();
                    DatItems[nIds].AddByte(readbyte, "sprparam");
                    DatItems[nIds].BlendFrame = readbyte;

                    //Xrepeat
                    readbyte = readdat.ReadByte();
                    DatItems[nIds].AddByte(readbyte, "sprparam");
                    DatItems[nIds].XRepeat = readbyte;

                    //Yrepeat
                    readbyte = readdat.ReadByte();
                    DatItems[nIds].AddByte(readbyte, "sprparam");
                    DatItems[nIds].YRepeat = readbyte;

                    //Zrepeat
                    readbyte = readdat.ReadByte();
                    DatItems[nIds].AddByte(readbyte, "sprparam");
                    DatItems[nIds].ZRepeat = readbyte;

                    //animation
                    readbyte = readdat.ReadByte();
                    DatItems[nIds].AddByte(readbyte, "sprparam");
                    DatItems[nIds].Animation = readbyte;

                    try
                    {
                        DatItems[nIds].CountSprites();
                        byte[] byte_array = new byte[2];
                        for (int i = 0; i < DatItems[nIds].SpritesNumber; i++)
                        {
                            string param;
                            if (i % 2 == 0) { param = "sprid1"; }
                            else { param = "sprid2"; }
                            //Primeiro byte
                            byte_array[0] = readdat.ReadByte();
                            DatItems[nIds].AddByte(byte_array[0], param);

                            //Segundo byte
                            byte_array[1] = readdat.ReadByte();
                            DatItems[nIds].AddByte(byte_array[1], param);
                            DatItems[nIds].SpritesId[i] = BitConverter.ToUInt16(byte_array, 0);//Convert.ToUInt16((byte_array[0] + byte_array[1]).ToString());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível ler o arquivo por inteiro! \n Erro no item: " + nIds.ToString() + ".", "::ERROR::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nIds = uint.Parse((IdOffset + numberOfAll).ToString());
                    }
                    nIds++;
                }//fim do while gigante
                readdat.Close();
                return true;
            }//if que verifica se o arquivo pode ser aberto
            else
            {
                return false;
            }
        }

        private byte PeekByte(BinaryReader binreader)
        {
                long position = binreader.BaseStream.Position;
                byte next = binreader.ReadByte();
                binreader.BaseStream.Seek(position, SeekOrigin.Begin);
                return next;
        }
    }
    #endregion
    #region Classes referente a criação de um DatItem
    /* Um DatItem[] contem todas as informações das configurações das sprites do tibia
     * desde itens e seus comportamentos no jogo e suas animações, como também outifits,
     * efeitos de magias, objetos que são lançados, enfim, tudo que se refere a configuração
     * de como uma sprite deve se comportar no client
     */
    //Essa classe recebe as infomações de cada item
    class DatItem
    {
        //É um chão?
        public groundtile GroundTile = new groundtile();

        //Top order 1
        public bool TopOrder1 = false; //sempre no topo prioridade alta, novo ???

        //Top order 2
        public bool TopOrder2 = false; //sempre no topo baixa prioridade ???

        //Top order 3
        public bool TopOrder3 = false; //pode andar - portas etc ???

        //Quando dá para colocar coisas dentro disso
        public bool IsContainer = false;

        //amontoavel, empilhavel, varios ;D
        public bool IsStackable = false;

        //Corpo
        public bool IsCorpse = false;

        //Usavel
        public bool IsUseable = false;

        //Rune
        public bool IsRune = false;

        //É escrevivel
        public writeable Writeable = new writeable();

        //Apenas para leitura
        public onlyreadable OnlyReadable = new onlyreadable();

        //Fluidos
        public bool IsFluidContainer = false;

        //Splash
        public bool IsSplash = false;

        //Bloqueia a passagem
        public bool IsBlocking = false;

        //Impossível de se mover
        public bool IsImmobile = false;

        //Impede que uma coisa que foi atirada chegue em outro jogador
        public bool IsMissileBlocking = false;

        //Impede que uma magia de area atravesse
        public bool IsPathBlocking = false;

        //??????????
        public extraInfo ExtraInfo = new extraInfo();

        //Pode ser pego
        public bool IsPickUpAble = false;

        //Decoração fora da parede
        public bool IsHangableOff = false;

        //Decoração na parede, na horizontal
        public bool IsHangableHorizontal = false;

        //Decoração na parede, na vertical
        public bool IsHangableVertical = false;

        //Rodavel
        public bool IsRotatable = false;

        //Tem luz?
        public light Light = new light();

        //É capaz de alterar sua posição em Z? (escadas e buracos)
        public bool IsChangeFloor = false;

        //Deslocamento da sprite em X e Y em relação ao local onde ela é colocada (montanhas por exemplo)
        public offset Offset = new offset();

        //Deslocamento considerando a altura
        public raised Raised = new raised();

        //??
        public bool IsLayer = false;

        //Animação ociosa??
        public bool IsIdleAnimation = false;

        //esta ativo no minimapa?
        public minimap MiniMap = new minimap();

        public hasHelp HasHelp = new hasHelp();

        public bool isGround = false; //Fecha o Ground será??

        //VARIAVEIS REFERENTE AS SPRITES
        public byte Width; //largura em sprites
        public byte Height; //altura em sprites
        //if (width > 1 || height > 1) { apare um Unknow }
        public byte BlendFrame; //quando você tem um outfit com opção de mudar de cor
        public byte XRepeat; //repetição do item em direção X, por exemplo, se você põe um item 100 (VOID) um do lado do outro, os dois não são iguais, mas tem um padrão de repetição
        public byte YRepeat; //Yrepet é a mesma coisa que o X, e ainda, o padrão é dado por valores como 1, 2, 3, 4 ext, se o padrão for 4, então a repetição será 1234123412334, se for 2 o padrão será 1212121212
        public byte ZRepeat;
        public byte Animation;

        public int SpritesNumber; //quantidade de sprites
        public UInt32[] SpritesId;
        public void CountSprites()
        {
            if (Width > 0 && Height > 0 && BlendFrame > 0 && XRepeat > 0 && ZRepeat > 0 && YRepeat > 0 && Animation > 0)
            {
                SpritesNumber = Width * Height * BlendFrame * XRepeat * YRepeat * ZRepeat * Animation;
                SpritesId = new UInt32[SpritesNumber];
            }
        }

        public int IAmA; //Eu sou um??
        //0 = item
        //1 = criaturas
        //2 - efeitos
        //3 - misseis

        //Definir o que eu sou (Itens lidos, necessarios para eu ser uma criatura, mesma coisa para eu ser um efeito, o mesmo para um missil)
        public void setWhatIAm(UInt16 ItensRead, UInt16 ItemsTotal, UInt16 CreaturesTotal, UInt16 EffectsTotal) //Missiles não é necessario, ele é feio, ai a gente faz bullying ;D
        {
            CreaturesTotal += ItemsTotal;
            EffectsTotal += CreaturesTotal;
            if (ItensRead < ItemsTotal) //Se ainda não tem itens lidos o suficiente para ser uma criatura, você é um item
            {
                IAmA = 0;
            }

            else if (ItensRead < CreaturesTotal) //Se você ainda não tem itens lidos o suficiente para ser um efeito, você é uma criatura
            {
                IAmA = 1;
            }

            else if (ItensRead < EffectsTotal) //Se você ainda não tem itens lidos o suficiente para ser um missil, você é um efeito
            {
                IAmA = 2;
            }

            else// quando você já tem itens lidos suficiente para ser um missil ;D
            {
                IAmA = 3;
            }
        }

        //avisando que um byte desconhecido foi encontrado
        int unknows = 0;
        public byte[] myunks;
        public void Unknow(byte TheUnknowed)
        {
            unknows++;
            if (myunks != null)
            {
                byte[] backup = new byte[myunks.Length];
                //fazendo backpack porque a estrutura do array MYUNKS vai ser alterada
                for (int i = 0; i < myunks.Length; i++)
                {
                    backup[i] = myunks[i];
                }

                myunks = new byte[unknows];
                //recebendo de volta os valores do backup
                for (int i = 0; i < backup.Length; i++)
                {
                    myunks[i] = backup[i];
                }
            }

            else
            {
                myunks = new byte[unknows];
            }

            myunks[unknows - 1] = TheUnknowed; //recebendo o novo valor
        }

        //Guardando exatamente o byte de cada item para quando for salvar, salvar exatamente da forma como estava
        int bytesindex = 0;
        public byte[,] mybytes;
        public void AddByte(byte ByteAdded, string ByteType)
        {
            /* Types possiveis:
             * 
             * "att" (atributo) 
             * "param" (parâmetro)
             * "char" (caractere)
             * "end" (FF)
             * "sprparam" (parâmetro para contagem da sprite)
             * "sprid" (número de identificação de sprite)
             * 
             */
            bytesindex++;
            if (mybytes != null)
            {
                byte[,] backup = new byte[mybytes.GetLength(0), 2];
                //fazendo backpack porque a estrutura da matriz MYBYTES vai ser alterada
                for (int i = 0; i < mybytes.GetLength(0); i++)
                {
                    backup[i, 0] = mybytes[i, 0];
                    backup[i, 1] = mybytes[i, 1];
                }

                mybytes = new byte[bytesindex, 2];
                //recebendo de volta os valores do backup
                for (int i = 0; i < backup.GetLength(0); i++)
                {
                    mybytes[i, 0] = backup[i, 0];
                    mybytes[i, 1] = backup[i, 1];
                }
            }

            else
            {
                mybytes = new byte[bytesindex, 2];
            }

            mybytes[bytesindex - 1, 0] = ByteAdded; //recebendo o novo valor
            //adicionando o novo parâmetro que vai indicar o estilo do baguio no richtext
            switch (ByteType)
            {
                case "att":
                    mybytes[bytesindex - 1, 1] = 0;
                    break;
                case "param":
                    mybytes[bytesindex - 1, 1] = 1;
                    break;
                case "char":
                    mybytes[bytesindex - 1, 1] = 2;
                    break;
                case "end":
                    mybytes[bytesindex - 1, 1] = 3;
                    break;
                case "sprparam":
                    mybytes[bytesindex - 1, 1] = 4;
                    break;
                case "sprid1":
                    mybytes[bytesindex - 1, 1] = 5;
                    break;
                case "sprid2":
                    mybytes[bytesindex - 1, 1] = 6;
                    break;
            }
        }
    }//fim da classe

    #region subclasses da classe DatItem
    //É um chão?
    class groundtile
    {
        //É um chão?
        public bool Is = false;
        public UInt16 Speed; //Velocidade do player quando andar nesse chão - 0 significa que o player não pode andar
    }

    //É escrevivel
    class writeable
    {
        public bool Is = false;
        public UInt16 MaxLength;
    }

    //Apenas para leitura
    class onlyreadable
    {
        public bool Is = false;
        public UInt16 MaxLength;
    }

    //luz
    class light
    {
        public bool Is = false;
        public UInt16 Radius; //raio
        public UInt16 Color; //cor -- 0 significa que não há luz, coisa tosca né?
    }

    //deslocamento
    class offset
    {
        //[is offset] + [2 bytes X offset] + [2 bytes Y offset]. Offset in pixels to draw the sprite from the tile
        public bool Is = false;
        public UInt16 X;
        public UInt16 Y;
    }

    //deslocamento pela altura
    class raised
    {
        //[is raised] + [2 bytes height]. similar to offset, but both X and Y are offset by height
        public bool Is = false;
        public UInt16 Height;
    }

    class minimap
    {
        public bool Is = false;
        public UInt16 Color;
    }

    //If you use the client help function will anything show up
    class hasHelp
    {
        public bool Is = false; //Tem ajuda?
        public string Value; //Valor da ajuda (1 Byte depois do que identifica o que é)
        public void setHelpValue(byte helpbyte)
        {
            if (helpbyte == 0x4E) { Value = "IsRopeSpot"; }
            else if (helpbyte == 0x4F) { Value = "IsSwitch"; }
            else if (helpbyte == 0x50) { Value = "IsDoor"; }
            else if (helpbyte == 0x51) { Value = "IsDoorWithLock"; }
            else if (helpbyte == 0x52) { Value = "IsStairs"; }
            else if (helpbyte == 0x53) { Value = "IsMailBox"; }
            else if (helpbyte == 0x54) { Value = "IsDepot"; }
            else if (helpbyte == 0x55) { Value = "IsTrash"; }
            else if (helpbyte == 0x56) { Value = "IsHole"; }
            else if (helpbyte == 0x57) { Value = "IsSpecialDescription"; }
            else if (helpbyte == 0x58) { Value = "IsReadOnly"; }
            else { Value = "Unknow"; }
        }
    }

    //Adicionados nas versões 9.x
    class extraInfo
    {
        //não sei pra que serve D:
        public string Text = "";
        public UInt16 Length;
    }
    #endregion
    #endregion
}
