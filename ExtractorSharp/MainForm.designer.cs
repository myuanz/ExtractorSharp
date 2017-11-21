﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ExtractorSharp.View;
using ExtractorSharp.UI;
using ExtractorSharp.Draw;
using ExtractorSharp.Core;
using System.IO;
using ExtractorSharp.Config;
using ExtractorSharp.Data;

namespace ExtractorSharp {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            components = new Container();
            albumList = new EaseListBox<Album>();
            albumListMenu = albumList.ContextMenuStrip;


            cutImgItem = new ToolStripMenuItem();
            copyImgItem = new ToolStripMenuItem();
            pasteImgItem = new ToolStripMenuItem();

            replaceItem = new ToolStripMenuItem();
            saveAsItem = new ToolStripMenuItem();
            newImgItem = new ToolStripMenuItem();
            hideImgItem = new ToolStripMenuItem();
            addSpliceItem = new ToolStripMenuItem();
            encryptItem = new ToolStripMenuItem();
            deleteEncryptItem = new ToolStripMenuItem();
            addOutsideSpliceItem = new ToolStripMenuItem();
            runSpliceItem = new ToolStripMenuItem();
            renameItem = new ToolStripMenuItem();


            repairImgItem = new ToolStripMenuItem();
            splitImgItem = new ToolStripMenuItem();
            mixImgItem = new ToolStripMenuItem();

            imageList = new EaseListBox<ImageEntity>();
            imageListMenu = imageList.ContextMenuStrip;
            cutImageItem = new ToolStripMenuItem();
            copyImageItem = new ToolStripMenuItem();
            pasteImageItem = new ToolStripMenuItem();

            addLayerItem = new ToolStripMenuItem();
            saveImageItem = new ToolStripMenuItem();
            changePositionItem = new ToolStripMenuItem();
            changeSizeItem = new ToolStripMenuItem();

            adjustPositionItem = new ToolStripMenuItem();
            replaceImageItem = new ToolStripMenuItem();
            hideCheckImageItem = new ToolStripMenuItem();
            linkImageItem = new ToolStripMenuItem();
            newImageItem = new ToolStripMenuItem();
            saveSingleImageItem = new ToolStripMenuItem();
            saveAllImageItem = new ToolStripMenuItem();
            openFileItem = new ToolStripMenuItem();
            saveFileItem = new ToolStripMenuItem();

            convertItem = new ToolStripMenuItem();

            mainMenu = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            addFileItem = new ToolStripMenuItem();
            openDirItem = new ToolStripMenuItem();
            saveAsFileItem = new ToolStripMenuItem();
            saveDirItem = new ToolStripMenuItem();

            toolsItem = new ToolStripMenuItem();
            cavasImageItem = new ToolStripMenuItem();
            uncavasImageItem = new ToolStripMenuItem();
            lineDodgeItem = new ToolStripMenuItem();

            editMenu = new ToolStripMenuItem();
            undoItem = new ToolStripMenuItem();
            redoItem = new ToolStripMenuItem();
            classifyItem = new ToolStripMenuItem();

            viewMenu = new ToolStripMenuItem();

            ruleItem = new ToolStripMenuItem();
            displayRuleItem = new ToolStripMenuItem();
            displayRuleCrossHairItem = new ToolStripMenuItem();
            adjustRuleItem = new ToolStripMenuItem();
            lockRuleItem = new ToolStripMenuItem();
            previewItem = new ToolStripMenuItem();

            gridItem = new ToolStripMenuItem();

            fitItem = new ToolStripMenuItem();
            aboutItem = new ToolStripMenuItem();
            sortItem = new ToolStripMenuItem();
            macroItem = new ToolStripMenuItem();

            toolsMenu = new ToolStripMenuItem();

            modelMenu = new ToolStripMenuItem();
            clearItem = new ToolStripMenuItem();
            otherSeverItem = new ToolStripMenuItem();
            searchItem = new ToolStripMenuItem();

            Messager Messager = Messager.Default;
            saveGifItem = new ToolStripMenuItem();
            batItem = new ToolStripMenuItem();
            box = new EaseCavasBox();
            mutipleLayerItem = new ToolStripMenuItem();
            linedodgeBox = new CheckBox();
            realPostionBox = new CheckBox();
            onionskinBox = new CheckBox();
            displayBox = new CheckBox();
            displayBackBox = new ComboBox();

            openButton = new EaseButton();
            closeButton = new EaseButton();
            historyButton = new EaseButton();
            changeBackButton = new EaseButton();
            searchBox = new TextBox();
            pathBox = new TextBox();
            lastSaveLabel = new Label();

            scaleLabel = new Label();
            scaleBox = new NumericUpDown();
            aboutMenu = new ToolStripMenuItem();
            debugItem = new ToolStripMenuItem();
            versionItem = new ToolStripMenuItem();
            pluginItem = new ToolStripMenuItem();
            propertyItem = new ToolStripMenuItem();

            trackBar = new TrackBar();

            layerList = new EaseListBox<Layer>();
            layerMenu = layerList.ContextMenuStrip;
            renameLayerItem = new ToolStripMenuItem();
            changeLayerPositionItem = new ToolStripMenuItem();
            adjustEntityPositionItem = new ToolStripMenuItem();
            loadModelItem = new ToolStripMenuItem();
            saveAsLayerItem = new ToolStripMenuItem();
            replaceLayerItem = new ToolStripMenuItem();

            previewPanel = new Panel();
            colorPanel = new Panel();
            albumListMenu.SuspendLayout();
            imageListMenu.SuspendLayout();
            mainMenu.SuspendLayout();
            ((ISupportInitialize)(box)).BeginInit();
            SuspendLayout();
            // 
            // albumList
            // 
            albumList.HorizontalScrollbar = true;
            albumList.Location = new Point(20, 90);
            albumList.Name = "albumList";
            albumList.Size = new Size(200, 579);
            albumList.TabIndex = 3;
            albumList.CanClear = false;
            // 
            // albumListMenu
            // 
            albumListMenu.Items.Add(newImgItem);
            albumListMenu.Items.Add(cutImgItem);
            albumListMenu.Items.Add(copyImgItem);
            albumListMenu.Items.Add(pasteImgItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Items.Add(replaceItem);
            albumListMenu.Items.Add(saveAsItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Items.Add(repairImgItem);
            albumListMenu.Items.Add(splitImgItem);
            albumListMenu.Items.Add(mixImgItem);
            albumListMenu.Items.AddSeparator();
            albumListMenu.Items.Add(hideImgItem);
            albumListMenu.Items.Add(renameItem);
            albumListMenu.Items.Add(convertItem);
            albumListMenu.Items.Add(new ToolStripSeparator());
            albumListMenu.Items.Add(addSpliceItem);
            albumListMenu.Items.Add(addOutsideSpliceItem);
            albumListMenu.Items.Add(runSpliceItem);
            albumListMenu.Items.Add(new ToolStripSeparator());
            albumListMenu.Items.Add(encryptItem);
            albumListMenu.Items.Add(deleteEncryptItem);
            albumListMenu.Size = new Size(221, 268);
            replaceItem.Text = Language["ReplaceFile"];
            replaceItem.ShortcutKeys = Keys.Control | Keys.Q;

            cutImgItem.Text = Language["Cut"];
            cutImgItem.ShortcutKeys = Keys.Control | Keys.X;
            copyImgItem.Text = Language["Copy"];
            copyImgItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteImgItem.Text = Language["Paste"];
            pasteImgItem.ShortcutKeys = Keys.Control | Keys.V;

            saveAsItem.Text = Language["SaveAs"];
            saveAsItem.ShortcutKeys = Keys.Control | Keys.E;
            newImgItem.Text = Language["NewFile"];
            newImgItem.ShortcutKeys = Keys.Control | Keys.N;
            hideImgItem.Text = Language["HideImg"];
            hideImgItem.ShortcutKeys = Keys.Control | Keys.H;
            convertItem.Text = Language["ConvertVersion"];
            addSpliceItem.Text = Language["AddSplice"];
            addSpliceItem.ShortcutKeys = Keys.Control | Keys.M;
            addOutsideSpliceItem.Text = Language["AddOutsideSplice"];
            addOutsideSpliceItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.M;
            encryptItem.Text = Language["Encrypt"];
            deleteEncryptItem.Text = Language["DeletePassword"];
            runSpliceItem.Text = Language["RunSplice"];
            renameItem.Text = Language["Rename"];
            renameItem.ShortcutKeys = Keys.Control | Keys.R;
            repairImgItem.Text = Language["RepairImg"];
            splitImgItem.Text = Language["SplitFile"];
            mixImgItem.Text = Language["MixFile"];
            // 
            // imageList
            // 
            imageList.HorizontalScrollbar = true;
            imageList.Location = new Point(1050, 90);
            imageList.Name = "imageList";
            imageList.Size = new Size(240, 280);
            imageList.TabIndex = 4;
            imageList.CanClear = false;
            // 
            // imageListMenu
            // 
            imageListMenu.Items.Add(newImageItem);
            imageListMenu.Items.Add(cutImageItem);
            imageListMenu.Items.Add(copyImageItem);
            imageListMenu.Items.Add(pasteImageItem);
            imageListMenu.Items.Add(replaceImageItem);
            imageListMenu.Items.Add(new ToolStripSeparator());
            imageListMenu.Items.Add(addLayerItem);
            imageListMenu.Items.Add(changePositionItem);
            imageListMenu.Items.Add(changeSizeItem);
            imageListMenu.Items.Add(new ToolStripSeparator());
            imageListMenu.Items.Add(saveImageItem);
            imageListMenu.Items.Add(saveSingleImageItem);
            imageListMenu.Items.Add(saveAllImageItem);
            imageListMenu.Items.Add(saveGifItem);
            imageListMenu.Items.Add(new ToolStripSeparator());
            imageListMenu.Items.Add(hideCheckImageItem);
            imageListMenu.Items.Add(linkImageItem);
            imageListMenu.Items.Add(toolsItem);
            imageListMenu.Name = "imageListMenu";
            imageListMenu.Size = new Size(161, 202);

            cutImageItem.Text = Language["Cut"];
            copyImageItem.Text = Language["Copy"];
            pasteImageItem.Text = Language["Paste"];

            saveImageItem.Text = Language["SaveImage"];
            saveSingleImageItem.Text = Language["SaveAs"];
            saveAllImageItem.Text = Language["SaveAllImage"];
            saveGifItem.Text = Language["SaveGif"];
            changePositionItem.Text = Language["ChangeImagePosition"];
            changeSizeItem.Text = Language["ChangeImageSize"];
            replaceImageItem.Text = Language["ReplaceImage"];
            hideCheckImageItem.Text = Language["HideImage"];
            linkImageItem.Text = Language["LinkImage"];
            newImageItem.Text = Language["NewImage"];
            addLayerItem.Text = Language["AddLayer"];

            toolsItem.Text = Language["Other"];
            cavasImageItem.Text = Language["CavasImage"];
            uncavasImageItem.Text = Language["UnCavasImage"];
            lineDodgeItem.Text = Language["LineDodge"];
            toolsItem.DropDownItems.Add(cavasImageItem);
            toolsItem.DropDownItems.Add(uncavasImageItem);
            toolsItem.DropDownItems.Add(new ToolStripSeparator());
            toolsItem.DropDownItems.Add(lineDodgeItem);
            // 
            // mainMenu
            // 
            mainMenu.BackColor = Color.Transparent;
            mainMenu.Items.Add(fileMenu);
            mainMenu.Items.Add(editMenu);
            mainMenu.Items.Add(viewMenu);
            mainMenu.Items.Add(toolsMenu);
            mainMenu.Items.Add(modelMenu);
            mainMenu.Items.Add(batItem);
            mainMenu.Items.Add(macroItem);
            mainMenu.Items.Add(aboutMenu);

            batItem.Text = Language["Batch"];
            macroItem.Text = Language["Action"];

            modelMenu.Text = Language["Model"];
            modelMenu.DropDownItems.Add(searchItem);
            modelMenu.DropDownItems.Add(clearItem);
            modelMenu.DropDownItems.Add(fitItem);
            //   modelMenu.DropDownItems.Add(otherSeverItem);
            searchItem.ShortcutKeys = Keys.Control | Keys.F;
            searchItem.Text = Language["SearchModel"];
            clearItem.Text = Language["ClearModel"];
            otherSeverItem.Text = "外服资源";
            fitItem.Text = Language["FitRoom"];

            aboutMenu.Text = Language["About"];
            aboutMenu.DropDownItems.Add(aboutItem);
            aboutMenu.DropDownItems.Add(versionItem);
            aboutMenu.DropDownItems.Add(debugItem);
            //  aboutMenu.DropDownItems.Add(pluginItem);
            aboutMenu.DropDownItems.Add(propertyItem);
            aboutItem.Text = Language["About"];
            versionItem.Text = Language["Features"];
            debugItem.Text = Language["FeedBack"];
            pluginItem.Text = Language["Plugin"];
            propertyItem.Text = Language["Setting"];

            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.Add(openFileItem);
            fileMenu.DropDownItems.Add(addFileItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator());
            fileMenu.DropDownItems.Add(saveFileItem);
            fileMenu.DropDownItems.Add(saveAsFileItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator());
            fileMenu.DropDownItems.Add(openDirItem);
            fileMenu.DropDownItems.Add(saveDirItem);
            fileMenu.Text = Language["File"];
            openFileItem.Text = Language["Open"];
            openFileItem.ShowShortcutKeys = false;
            openFileItem.ShortcutKeys = Keys.Control | Keys.O;
            saveFileItem.Text = Language["Save"];
            saveFileItem.ShowShortcutKeys = false;
            saveFileItem.ShortcutKeys = Keys.Control | Keys.S;

            addFileItem.Text = Language["Add"];
            addFileItem.ShowShortcutKeys = false;
            addFileItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;

            saveAsFileItem.Text = Language["SaveAs"];
            saveAsFileItem.ShowShortcutKeys = false;
            saveAsFileItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;

            openDirItem.Text = Language["OpenDir"];
            openDirItem.ToolTipText = "从文件夹打开多个img/npk文件";

            saveDirItem.Text = Language["SaveDir"];
            saveDirItem.ToolTipText = "将文件分割为多个img保存至文件夹";

            editMenu.Text = Language["Edit"];
            editMenu.DropDownItems.Add(undoItem);
            editMenu.DropDownItems.Add(redoItem);
            editMenu.DropDownItems.Add(new ToolStripSeparator());
            editMenu.DropDownItems.Add(adjustPositionItem);
            editMenu.DropDownItems.Add(new ToolStripSeparator());
            editMenu.DropDownItems.Add(classifyItem);
            editMenu.DropDownItems.Add(sortItem);
            undoItem.Text = Language["Undo"];
            undoItem.ShortcutKeys = Keys.Control | Keys.Z;
            redoItem.Text = Language["Redo"];
            redoItem.ShortcutKeys = Keys.Control | Keys.Y;
            classifyItem.Text = Language["Classify"];
            classifyItem.CheckOnClick = true;
            sortItem.Text = Language["Sort"];
            adjustPositionItem.Text = Language["AdjustPosition"];
            adjustPositionItem.ShortcutKeys = Keys.Control | Keys.B;


            viewMenu.Text = Language["View"];
            viewMenu.DropDownItems.Add(ruleItem);
            viewMenu.DropDownItems.Add(gridItem);
            viewMenu.DropDownItems.Add(previewItem);
            viewMenu.DropDownItems.Add(mutipleLayerItem);
            ruleItem.Text = Language["Rule"];
            ruleItem.DropDownItems.Add(displayRuleItem);
            ruleItem.DropDownItems.Add(displayRuleCrossHairItem);
            ruleItem.DropDownItems.Add(lockRuleItem);
            ruleItem.DropDownItems.Add(adjustRuleItem);
            displayRuleItem.Text = Language["DisplayRule"];
            displayRuleItem.ShortcutKeys = Keys.Control | Keys.N;
            displayRuleItem.ShowShortcutKeys = true;
            displayRuleItem.CheckOnClick = true;
            displayRuleCrossHairItem.Text = Language["DisplayRuleCrossfair"];
            displayRuleCrossHairItem.ToolTipText = "显示准心可以让标尺移动";
            displayRuleCrossHairItem.CheckOnClick = true;
            displayRuleCrossHairItem.Checked = true;
            adjustRuleItem.Text = Language["AdjustRule"];
            adjustRuleItem.ToolTipText = "还原标尺位置";
            lockRuleItem.Text = Language["LockRule"];
            lockRuleItem.ToolTipText = "固定标尺，禁止移动";
            lockRuleItem.CheckOnClick = true;
            previewItem.Text = Language["Preview"];
            previewItem.CheckOnClick = true;
            previewItem.Checked = ViewConfig["Preview"].Boolean;
            gridItem.Text = Language["Grid"];
            gridItem.CheckOnClick = true;



            toolsMenu.Text = Language["Tools"];


            mutipleLayerItem.Text = Language["MutipleLayer"];
            mutipleLayerItem.CheckOnClick = true;
            // 
            // Message
            // 
            Messager.Location = new Point(1100, 30);
            Messager.Name = "Message";
            Messager.Size = new Size(250, 50);
            Messager.TabIndex = 9;
            Messager.Text = Language["Tips"];
            Messager.Visible = false;

            openButton.Location = new Point(20, 63);
            openButton.Text = Language["Open"];
            openButton.Size = new Size(75, 25);
            openButton.UseVisualStyleBackColor = true;

            closeButton.Location = new Point(145, 63);
            closeButton.Text = Language["Close"];
            closeButton.Size = new Size(75, 25);
            closeButton.UseVisualStyleBackColor = true;

            pathBox.Location = new Point(20, 40);
            pathBox.Size = new Size(200, 20);
            // 
            // box
            // 
            box.Location = new Point(230, 90);
            box.Name = "box";
            if (ViewConfig["CavasSize"].Size != Size.Empty) { 
                box.Size = ViewConfig["CavasSize"].Size;
            }
            // 
            // displayBackBox
            // 
            displayBackBox.Items.Add(Language["Color"]);
            displayBackBox.Items.Add(Language["Image"]);
            displayBackBox.Items.Add(Language["Null"]);
            displayBackBox.Location = new Point(680, 50);
            displayBackBox.Name = "displayBackBox";
            displayBackBox.Size = new Size(104, 20);
            displayBackBox.TabIndex = 12;
            displayBackBox.SelectedIndex = 0;
            // 
            // changeBackButton
            // 
            changeBackButton.Location = new Point(550, 48);
            changeBackButton.Name = "changeBackButton";
            changeBackButton.AutoSize = true;
            changeBackButton.Size = new Size(85, 25);
            changeBackButton.TabIndex = 19;
            changeBackButton.Text = Language["ChangeBackground"];
            changeBackButton.UseVisualStyleBackColor = true;
            //
            //colorPanel
            //
            colorPanel.Location = new Point(800, 48);
            colorPanel.BackColor = Color.White;
            colorPanel.Size = new Size(25, 25);
            ///
            ///
            ///
            scaleLabel.AutoSize = true;
            scaleLabel.Text = Language["CavasScale"];
            scaleLabel.Location = new Point(360, 53);

            ///
            ///
            ///
            scaleBox.Size = new Size(100, 40);
            scaleBox.Location = new Point(430, 50);
            scaleBox.Minimum = 20;
            scaleBox.Maximum = 100000;
            scaleBox.Value = 100;
            // 
            // realPostionBox
            // 
            realPostionBox.Location = new Point(1050, 50);
            realPostionBox.Name = "realPostionBox";
            realPostionBox.AutoSize = true;
            realPostionBox.TabIndex = 11;
            realPostionBox.Text = Language["RealPostion"];
            //
            //
            //
            displayBox.Location = new Point(1170, 50);
            displayBox.AutoSize = true;
            displayBox.Text = Language["Flash"];
            //
            //
            //
            linedodgeBox.Location = new Point(1050, 30);
            linedodgeBox.AutoSize = true;
            linedodgeBox.Text = Language["LineDodge"];
            ///
            //
            //
            onionskinBox.Location = new Point(1170, 30);
            onionskinBox.AutoSize = true;
            onionskinBox.Text = Language["OnionSkin"];
            //
            //
            //
            historyButton.Location = new Point(945, 47);
            historyButton.AutoSize = true;
            historyButton.Size = new Size(85, 25);
            historyButton.Text = Language["Other"];
            historyButton.UseVisualStyleBackColor = true;

            lastSaveLabel.Location = new Point(1250, 700);
            lastSaveLabel.Text = "lasttime:";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(20, 670);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(200, 20);
            searchBox.TabIndex = 6;
            // 
            // MainForm
            // 
            trackBar.Location = new Point(1050, 360);
            trackBar.Size = new Size(240, 40);
            trackBar.BackColor=Color.Black;
            trackBar.LargeChange = trackBar.SmallChange = 1;

            layerList.HorizontalScrollbar = true;
            layerList.Location = new Point(1050, 405);
            layerList.Name = "layerList";
            layerList.Size = new Size(240, 280);
            layerList.TabIndex = 4;

            layerMenu.Items.Add(renameLayerItem);
            layerMenu.Items.Add(replaceLayerItem);
            // layerMenu.Items.Add(changeLayerPositionItem);
            layerMenu.Items.Add(adjustEntityPositionItem);
            layerMenu.Items.Add(loadModelItem);
            layerMenu.Items.Add(saveAsLayerItem);
            renameLayerItem.Text = Language["Rename"];
            changeLayerPositionItem.Text = Language["ChangeLayerPosition"];
            adjustEntityPositionItem.Text = Language["AdjustPosition"];
            loadModelItem.Text = Language["LoadModel"];
            saveAsLayerItem.Text = Language["SaveAs"];
            replaceLayerItem.Text = Language["ReplaceImage"];

            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageList);
            Controls.Add(mainMenu);
            Controls.Add(searchBox);
            Controls.Add(albumList);
            Controls.Add(layerList);
            Controls.Add(trackBar);
            Controls.Add(Messager);
            Controls.Add(openButton);
            Controls.Add(closeButton);
            Controls.Add(pathBox);
            Controls.Add(realPostionBox);
            Controls.Add(displayBackBox);
            Controls.Add(displayBox);
            Controls.Add(linedodgeBox);
            Controls.Add(onionskinBox);
            Controls.Add(box);
            Controls.Add(historyButton);
            Controls.Add(changeBackButton);
            Controls.Add(colorPanel);
            Controls.Add(scaleLabel);
            Controls.Add(scaleBox);
            Controls.Add(lastSaveLabel);
            Controls.Add(previewPanel);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            Text = $"{ProductName} Ver { Program.Version} { ViewConfig["Title"]}";
            AllowDrop = true;
            CheckForIllegalCrossThreadCalls = false;
            if (!ViewConfig["StartPosition"].Value.ToLower().Equals("center")) {
                StartPosition = FormStartPosition.Manual;
                Location = ViewConfig["StartPosition"].Location;
            }
            if (ViewConfig["MainSize"].Size != Size.Empty) {
                Size = ViewConfig["MainSize"].Size;
            }
            if (ViewConfig["CavasColor"].Color != Color.Empty) {
                BackBoxColor = ViewConfig["CavasColor"].Color;
            }
            if (ViewConfig["CavasImage"].Image != null) {
                BackImage = ViewConfig["CavasImage"].Image;
            }
            if (ViewConfig["MainImage"] != null) {
                BackgroundImage = ViewConfig["MainImage"].Image;
            }
            if (ViewConfig["MainColor"].Color != Color.Empty) {
                BackColor = ViewConfig["MainColor"].Color;
            }
            if (File.Exists(ViewConfig["MainIcon"].Value)) {
                Icon = Icon.ExtractAssociatedIcon(ViewConfig["MainIcon"].Value);
            }
            BackgroundImageLayout = (ImageLayout)ViewConfig["MainImageLayout"].Integer;
            albumListMenu.ResumeLayout(false);
            imageListMenu.ResumeLayout(false);
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();

            previewPanel.Visible = ViewConfig["Preview"].Boolean;
            previewPanel.BorderStyle = BorderStyle.FixedSingle;
            previewPanel.Size = new Size(100, 100);
            previewPanel.BackgroundImageLayout = ImageLayout.Zoom;
            previewPanel.Location = new System.Drawing.Point(930, 90);
          
            ((ISupportInitialize)(box)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        
        public EaseListBox<Album> albumList;
        public EaseListBox<ImageEntity> imageList;
        public EaseListBox<Layer> layerList;

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileMenu; 
        private ToolStripMenuItem addFileItem;
        private ToolStripMenuItem saveFileItem;
        private ToolStripMenuItem saveAsFileItem;
        private ToolStripMenuItem saveDirItem;
        private ToolStripMenuItem openDirItem;
        private ToolStripMenuItem openFileItem;

        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem undoItem;
        private ToolStripMenuItem redoItem;
        private ToolStripMenuItem classifyItem;     //分类
        private ToolStripMenuItem sortItem;         //

        private ToolStripMenuItem aboutMenu;        //关于
        private ToolStripMenuItem aboutItem;        //关于
        private ToolStripMenuItem debugItem;        //问题反馈
        private ToolStripMenuItem versionItem;      //版本特性
        private ToolStripMenuItem pluginItem;       //插件拓展
        private ToolStripMenuItem propertyItem;     //设置

        private ToolStripMenuItem viewMenu;         //视图
        private ToolStripMenuItem ruleItem;         //标尺
        private ToolStripMenuItem displayRuleItem;  //显示标尺
        private ToolStripMenuItem displayRuleCrossHairItem; //显示标尺准心
        private ToolStripMenuItem adjustRuleItem;   //校正标尺
        private ToolStripMenuItem lockRuleItem;      //锁定标尺
        private ToolStripMenuItem previewItem;      //贴图预览

        private ToolStripMenuItem gridItem;         //网格
        private ToolStripMenuItem mutipleLayerItem; //多图层

        private ToolStripMenuItem toolsMenu;        //工具

        private ToolStripMenuItem fitItem;
        private ToolStripMenuItem batItem;          //批处理
        private ToolStripMenuItem macroItem;

        private ToolStripMenuItem modelMenu;      //模型管理
        private ToolStripMenuItem clearItem;        //清理模型
        private ToolStripMenuItem searchItem;       //搜索
        private ToolStripMenuItem otherSeverItem;     //外服资源

        private ContextMenuStrip albumListMenu;
        private ToolStripMenuItem newImgItem;       //新建文件
        private ToolStripMenuItem replaceItem;      //替换

        private ToolStripMenuItem cutImgItem;       //剪切
        private ToolStripMenuItem copyImgItem;      //复制
        private ToolStripMenuItem pasteImgItem;     //粘贴

        private ToolStripMenuItem saveAsItem;       //另存为
        private ToolStripMenuItem renameItem;       //重命名
        private ToolStripMenuItem convertItem;      //转换版本
        private ToolStripMenuItem hideImgItem;      //隐藏文件内所有贴图
        private ToolStripMenuItem addSpliceItem;    //加入拼合队列
        private ToolStripMenuItem addOutsideSpliceItem;//加入外部文件到拼合队列
        private ToolStripMenuItem runSpliceItem;    //执行拼合队列
        private ToolStripMenuItem encryptItem;      //密码保护
        private ToolStripMenuItem deleteEncryptItem;//删除密码
        private ToolStripMenuItem repairImgItem;    //帧数补正
        private ToolStripMenuItem splitImgItem;     //拆分文件
        private ToolStripMenuItem mixImgItem;       //合并文件

        private ContextMenuStrip imageListMenu;
        private ToolStripMenuItem saveImageItem;    //提取贴图到文件夹
        private ToolStripMenuItem saveSingleImageItem;   //提取贴图
        private ToolStripMenuItem saveAllImageItem; //提取所有贴图
        private ToolStripMenuItem saveGifItem;      //保存为gif
        private ToolStripMenuItem changePositionItem;//修改坐标
        private ToolStripMenuItem changeSizeItem;    //修改大小
        private ToolStripMenuItem replaceImageItem;  //替换贴图
        private ToolStripMenuItem hideCheckImageItem;//隐藏贴图
        private ToolStripMenuItem linkImageItem;     //修改为链接贴图
        private ToolStripMenuItem newImageItem; //新建贴图;

        private ToolStripMenuItem cutImageItem;     //剪切
        private ToolStripMenuItem copyImageItem;    //复制
        private ToolStripMenuItem pasteImageItem;   //粘贴

        private ToolStripMenuItem adjustPositionItem;//校正坐标
        private ToolStripMenuItem addLayerItem; //加入图层
        private ToolStripMenuItem toolsItem;    //拓展
        private ToolStripMenuItem cavasImageItem;//画布化贴图
        private ToolStripMenuItem uncavasImageItem;//去画布化贴图
        private ToolStripMenuItem lineDodgeItem; 


        private ComboBox displayBackBox;        //显示背景
        private CheckBox realPostionBox;        //真实坐标
        private CheckBox displayBox;            //动画播放
        private CheckBox linedodgeBox;          //线性减淡
        private CheckBox onionskinBox;             //模拟残影

        private Label scaleLabel;
        private NumericUpDown scaleBox;         //画布比例
        private Button changeBackButton;
        private Button openButton;              //打开文件
        private Button closeButton;             //关闭文件
        private PictureBox box;
        private TextBox searchBox;
        private TextBox pathBox;
        private Button historyButton;           //历史操作
        private Label lastSaveLabel;
        private TrackBar trackBar;

        private ContextMenuStrip layerMenu;
        private ToolStripMenuItem renameLayerItem;//重命名
        private ToolStripMenuItem changeLayerPositionItem;//修改图层坐标
        private ToolStripMenuItem replaceLayerItem;//替换贴图
        private ToolStripMenuItem adjustEntityPositionItem;//校正坐标
        private ToolStripMenuItem loadModelItem;    //载入模板
        private ToolStripMenuItem saveAsLayerItem;//另存为

        private DropPanel dropPanel;
        private DecryptPanel decryptPanel;
        private OggPlayer player;
        private Panel previewPanel;
        private Panel colorPanel;
    }
}
