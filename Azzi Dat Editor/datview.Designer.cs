namespace Azzi_Dat_Editor
{
    partial class datview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.previous = new System.Windows.Forms.Button();
            this.DatItemId = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.IsGroundTile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TheString = new System.Windows.Forms.TextBox();
            this.IsCloseGround = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IsHelp = new System.Windows.Forms.CheckBox();
            this.HelpByte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IsMinimap = new System.Windows.Forms.CheckBox();
            this.MinimapColor = new System.Windows.Forms.TextBox();
            this.IsIdleAnimation = new System.Windows.Forms.CheckBox();
            this.IsLayer = new System.Windows.Forms.CheckBox();
            this.IsRaised = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OffsetY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OffsetX = new System.Windows.Forms.TextBox();
            this.IsOffset = new System.Windows.Forms.CheckBox();
            this.IsChangeFloor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LightColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LightRadius = new System.Windows.Forms.TextBox();
            this.IsLight = new System.Windows.Forms.CheckBox();
            this.IsRotatable = new System.Windows.Forms.CheckBox();
            this.IsHangableVertical = new System.Windows.Forms.CheckBox();
            this.IsHangableHorizontal = new System.Windows.Forms.CheckBox();
            this.IsHangableOff = new System.Windows.Forms.CheckBox();
            this.IsPickUpAble = new System.Windows.Forms.CheckBox();
            this.IsPathBlocking = new System.Windows.Forms.CheckBox();
            this.IsMissileBlocking = new System.Windows.Forms.CheckBox();
            this.IsImmobile = new System.Windows.Forms.CheckBox();
            this.IsBlocking = new System.Windows.Forms.CheckBox();
            this.IsSplash = new System.Windows.Forms.CheckBox();
            this.IsFluidContainer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RaisedHeight = new System.Windows.Forms.TextBox();
            this.OnlyReadMaxLength = new System.Windows.Forms.TextBox();
            this.IsOnlyRead = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GroundSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WritableMaxLength = new System.Windows.Forms.TextBox();
            this.IsWritable = new System.Windows.Forms.CheckBox();
            this.IsRune = new System.Windows.Forms.CheckBox();
            this.IsUseable = new System.Windows.Forms.CheckBox();
            this.IsCorpse = new System.Windows.Forms.CheckBox();
            this.IsStackable = new System.Windows.Forms.CheckBox();
            this.IsContainer = new System.Windows.Forms.CheckBox();
            this.IsTopOrder3 = new System.Windows.Forms.CheckBox();
            this.IsTopOrder2 = new System.Windows.Forms.CheckBox();
            this.IsTopOrder1 = new System.Windows.Forms.CheckBox();
            this.UnknowBytes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SprList = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.ImportTibiaSPR = new System.Windows.Forms.Button();
            this.TheItemBytes = new System.Windows.Forms.RichTextBox();
            this.GoToItems = new System.Windows.Forms.Button();
            this.GoToCreatures = new System.Windows.Forms.Button();
            this.GoToEffects = new System.Windows.Forms.Button();
            this.GoToMissiles = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(12, 9);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(39, 23);
            this.previous.TabIndex = 0;
            this.previous.Text = "<<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // DatItemId
            // 
            this.DatItemId.Location = new System.Drawing.Point(142, 11);
            this.DatItemId.Name = "DatItemId";
            this.DatItemId.Size = new System.Drawing.Size(63, 20);
            this.DatItemId.TabIndex = 1;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(57, 9);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 23);
            this.next.TabIndex = 2;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // IsGroundTile
            // 
            this.IsGroundTile.AutoSize = true;
            this.IsGroundTile.Location = new System.Drawing.Point(6, 19);
            this.IsGroundTile.Name = "IsGroundTile";
            this.IsGroundTile.Size = new System.Drawing.Size(88, 17);
            this.IsGroundTile.TabIndex = 3;
            this.IsGroundTile.Text = "Ground Tile {";
            this.IsGroundTile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TheString);
            this.groupBox1.Controls.Add(this.IsCloseGround);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.IsHelp);
            this.groupBox1.Controls.Add(this.HelpByte);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.IsMinimap);
            this.groupBox1.Controls.Add(this.MinimapColor);
            this.groupBox1.Controls.Add(this.IsIdleAnimation);
            this.groupBox1.Controls.Add(this.IsLayer);
            this.groupBox1.Controls.Add(this.IsRaised);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.OffsetY);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.OffsetX);
            this.groupBox1.Controls.Add(this.IsOffset);
            this.groupBox1.Controls.Add(this.IsChangeFloor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LightColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LightRadius);
            this.groupBox1.Controls.Add(this.IsLight);
            this.groupBox1.Controls.Add(this.IsRotatable);
            this.groupBox1.Controls.Add(this.IsHangableVertical);
            this.groupBox1.Controls.Add(this.IsHangableHorizontal);
            this.groupBox1.Controls.Add(this.IsHangableOff);
            this.groupBox1.Controls.Add(this.IsPickUpAble);
            this.groupBox1.Controls.Add(this.IsPathBlocking);
            this.groupBox1.Controls.Add(this.IsMissileBlocking);
            this.groupBox1.Controls.Add(this.IsImmobile);
            this.groupBox1.Controls.Add(this.IsBlocking);
            this.groupBox1.Controls.Add(this.IsSplash);
            this.groupBox1.Controls.Add(this.IsFluidContainer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RaisedHeight);
            this.groupBox1.Controls.Add(this.OnlyReadMaxLength);
            this.groupBox1.Controls.Add(this.IsOnlyRead);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GroundSpeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WritableMaxLength);
            this.groupBox1.Controls.Add(this.IsWritable);
            this.groupBox1.Controls.Add(this.IsRune);
            this.groupBox1.Controls.Add(this.IsUseable);
            this.groupBox1.Controls.Add(this.IsCorpse);
            this.groupBox1.Controls.Add(this.IsStackable);
            this.groupBox1.Controls.Add(this.IsContainer);
            this.groupBox1.Controls.Add(this.IsTopOrder3);
            this.groupBox1.Controls.Add(this.IsTopOrder2);
            this.groupBox1.Controls.Add(this.IsTopOrder1);
            this.groupBox1.Controls.Add(this.IsGroundTile);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 285);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Config";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Title";
            // 
            // TheString
            // 
            this.TheString.Location = new System.Drawing.Point(319, 251);
            this.TheString.Name = "TheString";
            this.TheString.Size = new System.Drawing.Size(201, 20);
            this.TheString.TabIndex = 52;
            // 
            // IsCloseGround
            // 
            this.IsCloseGround.AutoSize = true;
            this.IsCloseGround.Location = new System.Drawing.Point(430, 161);
            this.IsCloseGround.Name = "IsCloseGround";
            this.IsCloseGround.Size = new System.Drawing.Size(88, 17);
            this.IsCloseGround.TabIndex = 51;
            this.IsCloseGround.Text = "} Ground Tile";
            this.IsCloseGround.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Help type";
            // 
            // IsHelp
            // 
            this.IsHelp.AutoSize = true;
            this.IsHelp.Location = new System.Drawing.Point(430, 87);
            this.IsHelp.Name = "IsHelp";
            this.IsHelp.Size = new System.Drawing.Size(48, 17);
            this.IsHelp.TabIndex = 49;
            this.IsHelp.Text = "Help";
            this.IsHelp.UseVisualStyleBackColor = true;
            // 
            // HelpByte
            // 
            this.HelpByte.Location = new System.Drawing.Point(430, 137);
            this.HelpByte.Name = "HelpByte";
            this.HelpByte.Size = new System.Drawing.Size(65, 20);
            this.HelpByte.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Color";
            // 
            // IsMinimap
            // 
            this.IsMinimap.AutoSize = true;
            this.IsMinimap.Location = new System.Drawing.Point(430, 19);
            this.IsMinimap.Name = "IsMinimap";
            this.IsMinimap.Size = new System.Drawing.Size(65, 17);
            this.IsMinimap.TabIndex = 46;
            this.IsMinimap.Text = "Minimap";
            this.IsMinimap.UseVisualStyleBackColor = true;
            // 
            // MinimapColor
            // 
            this.MinimapColor.Location = new System.Drawing.Point(430, 62);
            this.MinimapColor.Name = "MinimapColor";
            this.MinimapColor.Size = new System.Drawing.Size(65, 20);
            this.MinimapColor.TabIndex = 45;
            // 
            // IsIdleAnimation
            // 
            this.IsIdleAnimation.AutoSize = true;
            this.IsIdleAnimation.Location = new System.Drawing.Point(319, 206);
            this.IsIdleAnimation.Name = "IsIdleAnimation";
            this.IsIdleAnimation.Size = new System.Drawing.Size(92, 17);
            this.IsIdleAnimation.TabIndex = 44;
            this.IsIdleAnimation.Text = "Idle Animation";
            this.IsIdleAnimation.UseVisualStyleBackColor = true;
            // 
            // IsLayer
            // 
            this.IsLayer.AutoSize = true;
            this.IsLayer.Location = new System.Drawing.Point(319, 183);
            this.IsLayer.Name = "IsLayer";
            this.IsLayer.Size = new System.Drawing.Size(73, 17);
            this.IsLayer.TabIndex = 43;
            this.IsLayer.Text = "Layer [??]";
            this.IsLayer.UseVisualStyleBackColor = true;
            // 
            // IsRaised
            // 
            this.IsRaised.AutoSize = true;
            this.IsRaised.Location = new System.Drawing.Point(319, 114);
            this.IsRaised.Name = "IsRaised";
            this.IsRaised.Size = new System.Drawing.Size(59, 17);
            this.IsRaised.TabIndex = 40;
            this.IsRaised.Text = "Raised";
            this.IsRaised.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Y";
            // 
            // OffsetY
            // 
            this.OffsetY.Location = new System.Drawing.Point(336, 85);
            this.OffsetY.Name = "OffsetY";
            this.OffsetY.Size = new System.Drawing.Size(48, 20);
            this.OffsetY.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "X";
            // 
            // OffsetX
            // 
            this.OffsetX.Location = new System.Drawing.Point(336, 62);
            this.OffsetX.Name = "OffsetX";
            this.OffsetX.Size = new System.Drawing.Size(48, 20);
            this.OffsetX.TabIndex = 36;
            // 
            // IsOffset
            // 
            this.IsOffset.AutoSize = true;
            this.IsOffset.Location = new System.Drawing.Point(319, 42);
            this.IsOffset.Name = "IsOffset";
            this.IsOffset.Size = new System.Drawing.Size(54, 17);
            this.IsOffset.TabIndex = 35;
            this.IsOffset.Text = "Offset";
            this.IsOffset.UseVisualStyleBackColor = true;
            // 
            // IsChangeFloor
            // 
            this.IsChangeFloor.AutoSize = true;
            this.IsChangeFloor.Location = new System.Drawing.Point(319, 19);
            this.IsChangeFloor.Name = "IsChangeFloor";
            this.IsChangeFloor.Size = new System.Drawing.Size(110, 17);
            this.IsChangeFloor.TabIndex = 34;
            this.IsChangeFloor.Text = "Floor Change [??]";
            this.IsChangeFloor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Color";
            // 
            // LightColor
            // 
            this.LightColor.Location = new System.Drawing.Point(210, 252);
            this.LightColor.Name = "LightColor";
            this.LightColor.Size = new System.Drawing.Size(65, 20);
            this.LightColor.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Radius";
            // 
            // LightRadius
            // 
            this.LightRadius.Location = new System.Drawing.Point(209, 205);
            this.LightRadius.Name = "LightRadius";
            this.LightRadius.Size = new System.Drawing.Size(65, 20);
            this.LightRadius.TabIndex = 30;
            // 
            // IsLight
            // 
            this.IsLight.AutoSize = true;
            this.IsLight.Location = new System.Drawing.Point(210, 161);
            this.IsLight.Name = "IsLight";
            this.IsLight.Size = new System.Drawing.Size(49, 17);
            this.IsLight.TabIndex = 29;
            this.IsLight.Text = "Light";
            this.IsLight.UseVisualStyleBackColor = true;
            // 
            // IsRotatable
            // 
            this.IsRotatable.AutoSize = true;
            this.IsRotatable.Location = new System.Drawing.Point(210, 141);
            this.IsRotatable.Name = "IsRotatable";
            this.IsRotatable.Size = new System.Drawing.Size(72, 17);
            this.IsRotatable.TabIndex = 28;
            this.IsRotatable.Text = "Rotatable";
            this.IsRotatable.UseVisualStyleBackColor = true;
            // 
            // IsHangableVertical
            // 
            this.IsHangableVertical.AutoSize = true;
            this.IsHangableVertical.Location = new System.Drawing.Point(209, 118);
            this.IsHangableVertical.Name = "IsHangableVertical";
            this.IsHangableVertical.Size = new System.Drawing.Size(103, 17);
            this.IsHangableVertical.TabIndex = 27;
            this.IsHangableVertical.Text = "Hangable V [??]";
            this.IsHangableVertical.UseVisualStyleBackColor = true;
            // 
            // IsHangableHorizontal
            // 
            this.IsHangableHorizontal.AutoSize = true;
            this.IsHangableHorizontal.Location = new System.Drawing.Point(209, 92);
            this.IsHangableHorizontal.Name = "IsHangableHorizontal";
            this.IsHangableHorizontal.Size = new System.Drawing.Size(104, 17);
            this.IsHangableHorizontal.TabIndex = 26;
            this.IsHangableHorizontal.Text = "Hangable H [??]";
            this.IsHangableHorizontal.UseVisualStyleBackColor = true;
            // 
            // IsHangableOff
            // 
            this.IsHangableOff.AutoSize = true;
            this.IsHangableOff.Location = new System.Drawing.Point(209, 69);
            this.IsHangableOff.Name = "IsHangableOff";
            this.IsHangableOff.Size = new System.Drawing.Size(89, 17);
            this.IsHangableOff.TabIndex = 25;
            this.IsHangableOff.Text = "Hangable Off";
            this.IsHangableOff.UseVisualStyleBackColor = true;
            // 
            // IsPickUpAble
            // 
            this.IsPickUpAble.AutoSize = true;
            this.IsPickUpAble.Location = new System.Drawing.Point(209, 44);
            this.IsPickUpAble.Name = "IsPickUpAble";
            this.IsPickUpAble.Size = new System.Drawing.Size(86, 17);
            this.IsPickUpAble.TabIndex = 24;
            this.IsPickUpAble.Text = "Can Pick Up";
            this.IsPickUpAble.UseVisualStyleBackColor = true;
            // 
            // IsPathBlocking
            // 
            this.IsPathBlocking.AutoSize = true;
            this.IsPathBlocking.Location = new System.Drawing.Point(209, 19);
            this.IsPathBlocking.Name = "IsPathBlocking";
            this.IsPathBlocking.Size = new System.Drawing.Size(78, 17);
            this.IsPathBlocking.TabIndex = 23;
            this.IsPathBlocking.Text = "Block Path";
            this.IsPathBlocking.UseVisualStyleBackColor = true;
            // 
            // IsMissileBlocking
            // 
            this.IsMissileBlocking.AutoSize = true;
            this.IsMissileBlocking.Location = new System.Drawing.Point(105, 253);
            this.IsMissileBlocking.Name = "IsMissileBlocking";
            this.IsMissileBlocking.Size = new System.Drawing.Size(87, 17);
            this.IsMissileBlocking.TabIndex = 22;
            this.IsMissileBlocking.Text = "Block Missile";
            this.IsMissileBlocking.UseVisualStyleBackColor = true;
            // 
            // IsImmobile
            // 
            this.IsImmobile.AutoSize = true;
            this.IsImmobile.Location = new System.Drawing.Point(105, 230);
            this.IsImmobile.Name = "IsImmobile";
            this.IsImmobile.Size = new System.Drawing.Size(67, 17);
            this.IsImmobile.TabIndex = 21;
            this.IsImmobile.Text = "Immobile";
            this.IsImmobile.UseVisualStyleBackColor = true;
            // 
            // IsBlocking
            // 
            this.IsBlocking.AutoSize = true;
            this.IsBlocking.Location = new System.Drawing.Point(106, 207);
            this.IsBlocking.Name = "IsBlocking";
            this.IsBlocking.Size = new System.Drawing.Size(67, 17);
            this.IsBlocking.TabIndex = 20;
            this.IsBlocking.Text = "Blocking";
            this.IsBlocking.UseVisualStyleBackColor = true;
            // 
            // IsSplash
            // 
            this.IsSplash.AutoSize = true;
            this.IsSplash.Location = new System.Drawing.Point(105, 184);
            this.IsSplash.Name = "IsSplash";
            this.IsSplash.Size = new System.Drawing.Size(58, 17);
            this.IsSplash.TabIndex = 19;
            this.IsSplash.Text = "Splash";
            this.IsSplash.UseVisualStyleBackColor = true;
            // 
            // IsFluidContainer
            // 
            this.IsFluidContainer.AutoSize = true;
            this.IsFluidContainer.Location = new System.Drawing.Point(105, 161);
            this.IsFluidContainer.Name = "IsFluidContainer";
            this.IsFluidContainer.Size = new System.Drawing.Size(93, 17);
            this.IsFluidContainer.TabIndex = 18;
            this.IsFluidContainer.Text = "FluidContainer";
            this.IsFluidContainer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "MaxLength";
            // 
            // RaisedHeight
            // 
            this.RaisedHeight.Location = new System.Drawing.Point(319, 158);
            this.RaisedHeight.Name = "RaisedHeight";
            this.RaisedHeight.Size = new System.Drawing.Size(65, 20);
            this.RaisedHeight.TabIndex = 16;
            // 
            // OnlyReadMaxLength
            // 
            this.OnlyReadMaxLength.Location = new System.Drawing.Point(105, 137);
            this.OnlyReadMaxLength.Name = "OnlyReadMaxLength";
            this.OnlyReadMaxLength.Size = new System.Drawing.Size(65, 20);
            this.OnlyReadMaxLength.TabIndex = 16;
            // 
            // IsOnlyRead
            // 
            this.IsOnlyRead.AutoSize = true;
            this.IsOnlyRead.Location = new System.Drawing.Point(105, 92);
            this.IsOnlyRead.Name = "IsOnlyRead";
            this.IsOnlyRead.Size = new System.Drawing.Size(73, 17);
            this.IsOnlyRead.TabIndex = 15;
            this.IsOnlyRead.Text = "OnlyRead";
            this.IsOnlyRead.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ground Speed";
            // 
            // GroundSpeed
            // 
            this.GroundSpeed.Location = new System.Drawing.Point(7, 65);
            this.GroundSpeed.Name = "GroundSpeed";
            this.GroundSpeed.Size = new System.Drawing.Size(65, 20);
            this.GroundSpeed.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "MaxLength";
            // 
            // WritableMaxLength
            // 
            this.WritableMaxLength.Location = new System.Drawing.Point(105, 65);
            this.WritableMaxLength.Name = "WritableMaxLength";
            this.WritableMaxLength.Size = new System.Drawing.Size(65, 20);
            this.WritableMaxLength.TabIndex = 13;
            // 
            // IsWritable
            // 
            this.IsWritable.AutoSize = true;
            this.IsWritable.Location = new System.Drawing.Point(105, 19);
            this.IsWritable.Name = "IsWritable";
            this.IsWritable.Size = new System.Drawing.Size(65, 17);
            this.IsWritable.TabIndex = 12;
            this.IsWritable.Text = "Writable";
            this.IsWritable.UseVisualStyleBackColor = true;
            // 
            // IsRune
            // 
            this.IsRune.AutoSize = true;
            this.IsRune.Location = new System.Drawing.Point(6, 252);
            this.IsRune.Name = "IsRune";
            this.IsRune.Size = new System.Drawing.Size(73, 17);
            this.IsRune.TabIndex = 11;
            this.IsRune.Text = "Rune [??]";
            this.IsRune.UseVisualStyleBackColor = true;
            // 
            // IsUseable
            // 
            this.IsUseable.AutoSize = true;
            this.IsUseable.Location = new System.Drawing.Point(6, 229);
            this.IsUseable.Name = "IsUseable";
            this.IsUseable.Size = new System.Drawing.Size(65, 17);
            this.IsUseable.TabIndex = 10;
            this.IsUseable.Text = "Useable";
            this.IsUseable.UseVisualStyleBackColor = true;
            // 
            // IsCorpse
            // 
            this.IsCorpse.AutoSize = true;
            this.IsCorpse.Location = new System.Drawing.Point(6, 206);
            this.IsCorpse.Name = "IsCorpse";
            this.IsCorpse.Size = new System.Drawing.Size(59, 17);
            this.IsCorpse.TabIndex = 9;
            this.IsCorpse.Text = "Corpse";
            this.IsCorpse.UseVisualStyleBackColor = true;
            // 
            // IsStackable
            // 
            this.IsStackable.AutoSize = true;
            this.IsStackable.Location = new System.Drawing.Point(6, 183);
            this.IsStackable.Name = "IsStackable";
            this.IsStackable.Size = new System.Drawing.Size(74, 17);
            this.IsStackable.TabIndex = 8;
            this.IsStackable.Text = "Stackable";
            this.IsStackable.UseVisualStyleBackColor = true;
            // 
            // IsContainer
            // 
            this.IsContainer.AutoSize = true;
            this.IsContainer.Location = new System.Drawing.Point(6, 160);
            this.IsContainer.Name = "IsContainer";
            this.IsContainer.Size = new System.Drawing.Size(92, 17);
            this.IsContainer.TabIndex = 7;
            this.IsContainer.Text = "Container [??]";
            this.IsContainer.UseVisualStyleBackColor = true;
            // 
            // IsTopOrder3
            // 
            this.IsTopOrder3.AutoSize = true;
            this.IsTopOrder3.Location = new System.Drawing.Point(6, 137);
            this.IsTopOrder3.Name = "IsTopOrder3";
            this.IsTopOrder3.Size = new System.Drawing.Size(75, 17);
            this.IsTopOrder3.TabIndex = 6;
            this.IsTopOrder3.Text = "Float Style";
            this.IsTopOrder3.UseVisualStyleBackColor = true;
            // 
            // IsTopOrder2
            // 
            this.IsTopOrder2.AutoSize = true;
            this.IsTopOrder2.Location = new System.Drawing.Point(6, 114);
            this.IsTopOrder2.Name = "IsTopOrder2";
            this.IsTopOrder2.Size = new System.Drawing.Size(73, 17);
            this.IsTopOrder2.TabIndex = 5;
            this.IsTopOrder2.Text = "Wall Style";
            this.IsTopOrder2.UseVisualStyleBackColor = true;
            // 
            // IsTopOrder1
            // 
            this.IsTopOrder1.AutoSize = true;
            this.IsTopOrder1.Location = new System.Drawing.Point(6, 91);
            this.IsTopOrder1.Name = "IsTopOrder1";
            this.IsTopOrder1.Size = new System.Drawing.Size(57, 17);
            this.IsTopOrder1.TabIndex = 4;
            this.IsTopOrder1.Text = "Border";
            this.IsTopOrder1.UseVisualStyleBackColor = true;
            // 
            // UnknowBytes
            // 
            this.UnknowBytes.FormattingEnabled = true;
            this.UnknowBytes.Location = new System.Drawing.Point(6, 34);
            this.UnknowBytes.Name = "UnknowBytes";
            this.UnknowBytes.Size = new System.Drawing.Size(116, 69);
            this.UnknowBytes.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SprList);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.UnknowBytes);
            this.groupBox2.Location = new System.Drawing.Point(552, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 285);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // SprList
            // 
            this.SprList.Location = new System.Drawing.Point(6, 129);
            this.SprList.Name = "SprList";
            this.SprList.Size = new System.Drawing.Size(116, 150);
            this.SprList.TabIndex = 59;
            this.SprList.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Onlyread-Sprites";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Unknows";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(211, 9);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(40, 23);
            this.Go.TabIndex = 7;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // ImportTibiaSPR
            // 
            this.ImportTibiaSPR.Location = new System.Drawing.Point(578, 9);
            this.ImportTibiaSPR.Name = "ImportTibiaSPR";
            this.ImportTibiaSPR.Size = new System.Drawing.Size(105, 23);
            this.ImportTibiaSPR.TabIndex = 56;
            this.ImportTibiaSPR.Text = "Import Tibia.spr";
            this.ImportTibiaSPR.UseVisualStyleBackColor = true;
            this.ImportTibiaSPR.Click += new System.EventHandler(this.ImportTibiaSPR_Click);
            // 
            // TheItemBytes
            // 
            this.TheItemBytes.Location = new System.Drawing.Point(12, 334);
            this.TheItemBytes.Name = "TheItemBytes";
            this.TheItemBytes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TheItemBytes.Size = new System.Drawing.Size(671, 96);
            this.TheItemBytes.TabIndex = 57;
            this.TheItemBytes.Text = "";
            // 
            // GoToItems
            // 
            this.GoToItems.Location = new System.Drawing.Point(325, 9);
            this.GoToItems.Name = "GoToItems";
            this.GoToItems.Size = new System.Drawing.Size(44, 23);
            this.GoToItems.TabIndex = 58;
            this.GoToItems.Text = "Items";
            this.GoToItems.UseVisualStyleBackColor = true;
            this.GoToItems.Click += new System.EventHandler(this.GoToItems_Click);
            // 
            // GoToCreatures
            // 
            this.GoToCreatures.Location = new System.Drawing.Point(375, 9);
            this.GoToCreatures.Name = "GoToCreatures";
            this.GoToCreatures.Size = new System.Drawing.Size(60, 23);
            this.GoToCreatures.TabIndex = 59;
            this.GoToCreatures.Text = "Creatures";
            this.GoToCreatures.UseVisualStyleBackColor = true;
            this.GoToCreatures.Click += new System.EventHandler(this.GoToCreatures_Click);
            // 
            // GoToEffects
            // 
            this.GoToEffects.Location = new System.Drawing.Point(442, 9);
            this.GoToEffects.Name = "GoToEffects";
            this.GoToEffects.Size = new System.Drawing.Size(44, 23);
            this.GoToEffects.TabIndex = 60;
            this.GoToEffects.Text = "Effect";
            this.GoToEffects.UseVisualStyleBackColor = true;
            this.GoToEffects.Click += new System.EventHandler(this.GoToEffects_Click);
            // 
            // GoToMissiles
            // 
            this.GoToMissiles.Location = new System.Drawing.Point(492, 9);
            this.GoToMissiles.Name = "GoToMissiles";
            this.GoToMissiles.Size = new System.Drawing.Size(54, 23);
            this.GoToMissiles.TabIndex = 61;
            this.GoToMissiles.Text = "Missiles";
            this.GoToMissiles.UseVisualStyleBackColor = true;
            this.GoToMissiles.Click += new System.EventHandler(this.GoToMissiles_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Height";
            // 
            // datview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 440);
            this.Controls.Add(this.GoToMissiles);
            this.Controls.Add(this.GoToEffects);
            this.Controls.Add(this.GoToCreatures);
            this.Controls.Add(this.GoToItems);
            this.Controls.Add(this.TheItemBytes);
            this.Controls.Add(this.ImportTibiaSPR);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.DatItemId);
            this.Controls.Add(this.previous);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "datview";
            this.Text = "datview";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.TextBox DatItemId;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.CheckBox IsGroundTile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox IsContainer;
        private System.Windows.Forms.CheckBox IsTopOrder3;
        private System.Windows.Forms.CheckBox IsTopOrder2;
        private System.Windows.Forms.CheckBox IsTopOrder1;
        private System.Windows.Forms.CheckBox IsBlocking;
        private System.Windows.Forms.CheckBox IsSplash;
        private System.Windows.Forms.CheckBox IsFluidContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OnlyReadMaxLength;
        private System.Windows.Forms.CheckBox IsOnlyRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WritableMaxLength;
        private System.Windows.Forms.CheckBox IsWritable;
        private System.Windows.Forms.CheckBox IsRune;
        private System.Windows.Forms.CheckBox IsUseable;
        private System.Windows.Forms.CheckBox IsCorpse;
        private System.Windows.Forms.CheckBox IsStackable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LightColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LightRadius;
        private System.Windows.Forms.CheckBox IsLight;
        private System.Windows.Forms.CheckBox IsRotatable;
        private System.Windows.Forms.CheckBox IsHangableVertical;
        private System.Windows.Forms.CheckBox IsHangableHorizontal;
        private System.Windows.Forms.CheckBox IsHangableOff;
        private System.Windows.Forms.CheckBox IsPickUpAble;
        private System.Windows.Forms.CheckBox IsPathBlocking;
        private System.Windows.Forms.CheckBox IsMissileBlocking;
        private System.Windows.Forms.CheckBox IsImmobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox IsMinimap;
        private System.Windows.Forms.TextBox MinimapColor;
        private System.Windows.Forms.CheckBox IsIdleAnimation;
        private System.Windows.Forms.CheckBox IsLayer;
        private System.Windows.Forms.CheckBox IsRaised;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OffsetY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OffsetX;
        private System.Windows.Forms.CheckBox IsOffset;
        private System.Windows.Forms.CheckBox IsChangeFloor;
        private System.Windows.Forms.TextBox RaisedHeight;
        private System.Windows.Forms.CheckBox IsCloseGround;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox IsHelp;
        private System.Windows.Forms.TextBox HelpByte;
        private System.Windows.Forms.ListBox UnknowBytes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GroundSpeed;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TheString;
        private System.Windows.Forms.Button ImportTibiaSPR;
        private System.Windows.Forms.RichTextBox TheItemBytes;
        private System.Windows.Forms.ListView SprList;
        private System.Windows.Forms.Button GoToItems;
        private System.Windows.Forms.Button GoToCreatures;
        private System.Windows.Forms.Button GoToEffects;
        private System.Windows.Forms.Button GoToMissiles;
        private System.Windows.Forms.Label label13;
    }
}