using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Azzi_Dat_Editor
{
    public partial class datview : Form
    {
        DatReader TibiaDat;
        SprReader TibiaSpr;

        public datview(string datpath)
        {
            InitializeComponent();
            //Lendo o arquivo dat logo que o formulário é iniciado
            TibiaDat = new DatReader();
            if (TibiaDat.OpenFile(datpath))
            {
                showItem(TibiaDat.DatItems, 100);
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            showItem(TibiaDat.DatItems, int.Parse(DatItemId.Text));
        }

        private void previous_Click(object sender, EventArgs e)
        {
            showItem(TibiaDat.DatItems, int.Parse(DatItemId.Text) - 1);
        }

        private void next_Click(object sender, EventArgs e)
        {
            showItem(TibiaDat.DatItems, int.Parse(DatItemId.Text) + 1);
        }

        private void ImportTibiaSPR_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Where is Tibia.spr?";
            openfile.Filter = "Tibia.spr|*.spr";
            openfile.ShowDialog();

            TibiaSpr = new SprReader(openfile.FileName);
            showItem(TibiaDat.DatItems, int.Parse(DatItemId.Text));
        }

        //Quando o Tibia.dat é aberto
        #region Função responsável por expor cada item
        private void showItem(DatItem[] TibiaDatItems, int i)//i é a indexagem do array
        {
            //Número de identificação do item
            DatItemId.Text = i.ToString();

            //Chão
            IsGroundTile.Checked = TibiaDatItems[i].GroundTile.Is;
            GroundSpeed.Text = TibiaDatItems[i].GroundTile.Speed.ToString();

            //TopOrder1
            IsTopOrder1.Checked = TibiaDatItems[i].TopOrder1;

            //TopOrder2
            IsTopOrder2.Checked = TibiaDatItems[i].TopOrder2;

            //TopOrder3
            IsTopOrder3.Checked = TibiaDatItems[i].TopOrder3;

            //IsContainer
            IsContainer.Checked = TibiaDatItems[i].IsContainer;

            //IsStackable
            IsStackable.Checked = TibiaDatItems[i].IsStackable;

            //IsCorpse
            IsCorpse.Checked = TibiaDatItems[i].IsCorpse;

            //IsUseable
            IsUseable.Checked = TibiaDatItems[i].IsUseable;

            //Writable
            IsWritable.Checked = TibiaDatItems[i].Writeable.Is;
            WritableMaxLength.Text = TibiaDatItems[i].Writeable.MaxLength.ToString();

            //OnlyRead
            IsOnlyRead.Checked = TibiaDatItems[i].OnlyReadable.Is;
            OnlyReadMaxLength.Text = TibiaDatItems[i].OnlyReadable.MaxLength.ToString();

            //IsFluidContainer
            IsFluidContainer.Checked = TibiaDatItems[i].IsFluidContainer;

            //IsSplash
            IsSplash.Checked = TibiaDatItems[i].IsSplash;

            //IsBlocking
            IsBlocking.Checked = TibiaDatItems[i].IsBlocking;

            //IsImmobile
            IsImmobile.Checked = TibiaDatItems[i].IsImmobile;

            //IsMissileBlocking
            IsMissileBlocking.Checked = TibiaDatItems[i].IsMissileBlocking;

            //IsPathBlocking
            IsPathBlocking.Checked = TibiaDatItems[i].IsPathBlocking;

            //TheString
            TheString.Text = TibiaDatItems[i].ExtraInfo.Text;

            //IsPickUpAble
            IsPickUpAble.Checked = TibiaDatItems[i].IsPickUpAble;

            //IsHangableOff
            IsHangableOff.Checked = TibiaDatItems[i].IsHangableOff;

            //IsHangableHorizontal
            IsHangableHorizontal.Checked = TibiaDatItems[i].IsHangableHorizontal;

            //IsHangableVertical
            IsHangableVertical.Checked = TibiaDatItems[i].IsHangableVertical;

            //Light
            IsLight.Checked = TibiaDatItems[i].Light.Is;
            LightRadius.Text = TibiaDatItems[i].Light.Radius.ToString();
            LightColor.Text = TibiaDatItems[i].Light.Color.ToString();

            //Rotate
            IsRotatable.Checked = TibiaDatItems[i].IsRotatable;

            //IsChangeFloor
            IsChangeFloor.Checked = TibiaDatItems[i].IsChangeFloor;

            //OffSet
            IsOffset.Checked = TibiaDatItems[i].Offset.Is;
            OffsetX.Text = TibiaDatItems[i].Offset.X.ToString();
            OffsetY.Text = TibiaDatItems[i].Offset.Y.ToString();

            //Raised
            IsRaised.Checked = TibiaDatItems[i].Raised.Is;
            RaisedHeight.Text = TibiaDatItems[i].Raised.Height.ToString();

            //Layer
            IsLayer.Checked = TibiaDatItems[i].IsLayer;

            //IdleAnimation
            IsIdleAnimation.Checked = TibiaDatItems[i].IsIdleAnimation;

            //Minimap
            IsMinimap.Checked = TibiaDatItems[i].MiniMap.Is;
            MinimapColor.Text = TibiaDatItems[i].MiniMap.Color.ToString();

            //Hashelp
            IsHelp.Checked = TibiaDatItems[i].HasHelp.Is;
            HelpByte.Text = TibiaDatItems[i].HasHelp.Value;

            //CloseGround
            IsCloseGround.Checked = TibiaDatItems[i].isGround;

            UnknowBytes.Items.Clear();
            //Exibindo os bytes desconhecidos
            if (TibiaDatItems[i].myunks != null)
            {
                for (int j = 0; j < TibiaDatItems[i].myunks.Length; j++)
                {
                    string hex = Convert.ToString(TibiaDatItems[i].myunks[j], 16).ToUpper();
                    if (hex.Length == 1) { hex = "0" + hex; }
                    UnknowBytes.Items.Add(hex);
                }
            }

            TheItemBytes.Text = "";
            //Exibindo os todos os bytes que formam o item
            /* Types possiveis:
             * 
             * 0 - "att" (atributo) 
             * 1 - "param" (parâmetro)
             * 2 - "char" (caractere)
             * 3 - "end" (FF)
             * 4 - "sprparam" (parâmetro para contagem da sprite)
             * 5 - "sprid1" (número de identificação de sprite)
             * 6 - "sprid2" (número de identificação de sprite)
             * 
             */

            if (TibiaDatItems[i].mybytes != null)
            {
                for (int j = 0; j < TibiaDatItems[i].mybytes.GetLength(0); j++)
                {
                    string hex = Convert.ToString(TibiaDatItems[i].mybytes[j, 0], 16).ToUpper();
                    switch (TibiaDatItems[i].mybytes[j, 1])
                    {
                        case 0:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Bold);
                            TheItemBytes.SelectionColor = Color.Black;
                            break;
                        case 1:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Italic);
                            TheItemBytes.SelectionColor = Color.DimGray;
                            break;
                        case 2:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Italic);
                            TheItemBytes.SelectionColor = Color.Maroon;
                            break;
                        case 3:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Bold);
                            TheItemBytes.SelectionColor = Color.Red;
                            break;
                        case 4:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Regular);
                            TheItemBytes.SelectionColor = Color.DeepPink;
                            break;
                        case 5:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Regular);
                            TheItemBytes.SelectionColor = Color.LimeGreen;
                            break;
                        case 6:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Regular);
                            TheItemBytes.SelectionColor = Color.Green;
                            break;
                        default:
                            TheItemBytes.SelectionFont = new Font("Arial", 8, FontStyle.Bold);
                            TheItemBytes.SelectionColor = Color.DodgerBlue;
                            break;

                    }
                    if (hex.Length == 1) { hex = "0" + hex; }
                    TheItemBytes.SelectedText = hex + "  ";
                }
            }

            //Exibindo as sprites
            try
            {
                SprList.Items.Clear();
                if (TibiaSpr != null)
                {
                    ImageList SpriteList = new ImageList(); //Criando uma nova lista de imagens
                    SpriteList.ImageSize = new Size(32, 32);

                    for (int j = 0; j < TibiaDatItems[i].SpritesNumber; j++)
                    {
                        UInt32 SprId = TibiaDatItems[i].SpritesId[j]; //pegando o número de identificação das imagens dentro do array de sprites
                        SpriteList.Images.Add(TibiaSpr.SprItems[SprId].SprBmp);
                    }

                    SprList.LargeImageList = SpriteList;
                    for (int j = 0; j < TibiaDatItems[i].SpritesNumber; j++)
                    {
                        string SprName = "s" + TibiaDatItems[i].SpritesId[j].ToString() + ".bmp";
                        SprList.Items.Add(SprName, j);
                    }
                }
            }
            catch
            {
            }
        }
        #endregion

        private void GoToItems_Click(object sender, EventArgs e)
        {
            showItem(TibiaDat.DatItems, 100);
        }

        private void GoToCreatures_Click(object sender, EventArgs e)
        {
            showItem(TibiaDat.DatItems, TibiaDat.numberOfItems + 1);
        }

        private void GoToEffects_Click(object sender, EventArgs e)
        {
            showItem(TibiaDat.DatItems, TibiaDat.numberOfItems + TibiaDat.numberOfCreatures + 1);
        }

        private void GoToMissiles_Click(object sender, EventArgs e)
        {
            showItem(TibiaDat.DatItems, TibiaDat.numberOfItems + TibiaDat.numberOfCreatures + TibiaDat.numberOfEffects + 1);
        }

    }
}
