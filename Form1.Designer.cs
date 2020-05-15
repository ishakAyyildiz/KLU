namespace KLU
{
    partial class GUI
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.kluWeb = new System.Windows.Forms.Button();
            this.kluBS = new System.Windows.Forms.Button();
            this.BtnNasilGiderim = new System.Windows.Forms.Button();
            this.yemekveOylama = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.kluLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.kapatma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.htmlViewer = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kluLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.kluLogo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(184, 788);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.kluWeb, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.kluBS, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnNasilGiderim, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.yemekveOylama, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnDuyurular, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 160);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(178, 625);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // kluWeb
            // 
            this.kluWeb.BackColor = System.Drawing.Color.White;
            this.kluWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kluWeb.FlatAppearance.BorderSize = 0;
            this.kluWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kluWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kluWeb.ForeColor = System.Drawing.Color.Black;
            this.kluWeb.Location = new System.Drawing.Point(1, 1);
            this.kluWeb.Margin = new System.Windows.Forms.Padding(1);
            this.kluWeb.Name = "kluWeb";
            this.kluWeb.Size = new System.Drawing.Size(176, 123);
            this.kluWeb.TabIndex = 0;
            this.kluWeb.Text = "Kırklareli Üniversitesi";
            this.kluWeb.UseVisualStyleBackColor = false;
            this.kluWeb.Click += new System.EventHandler(this.kluWeb_Click);
            // 
            // kluBS
            // 
            this.kluBS.BackColor = System.Drawing.Color.GhostWhite;
            this.kluBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kluBS.FlatAppearance.BorderSize = 0;
            this.kluBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kluBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kluBS.ForeColor = System.Drawing.Color.Black;
            this.kluBS.Location = new System.Drawing.Point(1, 126);
            this.kluBS.Margin = new System.Windows.Forms.Padding(1);
            this.kluBS.Name = "kluBS";
            this.kluBS.Size = new System.Drawing.Size(176, 123);
            this.kluBS.TabIndex = 1;
            this.kluBS.Text = "Kırklareli Bilgi Sistemi";
            this.kluBS.UseVisualStyleBackColor = false;
            this.kluBS.Click += new System.EventHandler(this.kluBS_Click);
            // 
            // BtnNasilGiderim
            // 
            this.BtnNasilGiderim.BackColor = System.Drawing.Color.White;
            this.BtnNasilGiderim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNasilGiderim.FlatAppearance.BorderSize = 0;
            this.BtnNasilGiderim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNasilGiderim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNasilGiderim.ForeColor = System.Drawing.Color.Black;
            this.BtnNasilGiderim.Location = new System.Drawing.Point(1, 251);
            this.BtnNasilGiderim.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNasilGiderim.Name = "BtnNasilGiderim";
            this.BtnNasilGiderim.Size = new System.Drawing.Size(176, 123);
            this.BtnNasilGiderim.TabIndex = 2;
            this.BtnNasilGiderim.Text = "Nasıl Giderim?";
            this.BtnNasilGiderim.UseVisualStyleBackColor = false;
            this.BtnNasilGiderim.Click += new System.EventHandler(this.Haritalar_Click);
            // 
            // yemekveOylama
            // 
            this.yemekveOylama.BackColor = System.Drawing.Color.GhostWhite;
            this.yemekveOylama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yemekveOylama.FlatAppearance.BorderSize = 0;
            this.yemekveOylama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yemekveOylama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yemekveOylama.ForeColor = System.Drawing.Color.Black;
            this.yemekveOylama.Location = new System.Drawing.Point(1, 376);
            this.yemekveOylama.Margin = new System.Windows.Forms.Padding(1);
            this.yemekveOylama.Name = "yemekveOylama";
            this.yemekveOylama.Size = new System.Drawing.Size(176, 123);
            this.yemekveOylama.TabIndex = 4;
            this.yemekveOylama.Text = "Günlük Yemek";
            this.yemekveOylama.UseVisualStyleBackColor = false;
            this.yemekveOylama.Click += new System.EventHandler(this.yemekveOylama_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.BackColor = System.Drawing.Color.White;
            this.btnDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuyurular.FlatAppearance.BorderSize = 0;
            this.btnDuyurular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyurular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyurular.ForeColor = System.Drawing.Color.Black;
            this.btnDuyurular.Location = new System.Drawing.Point(1, 501);
            this.btnDuyurular.Margin = new System.Windows.Forms.Padding(1);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(176, 123);
            this.btnDuyurular.TabIndex = 5;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = false;
            this.btnDuyurular.Click += new System.EventHandler(this.button1_Click);
            // 
            // kluLogo
            // 
            this.kluLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kluLogo.BackgroundImage")));
            this.kluLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kluLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kluLogo.Location = new System.Drawing.Point(0, 0);
            this.kluLogo.Margin = new System.Windows.Forms.Padding(0);
            this.kluLogo.Name = "kluLogo";
            this.kluLogo.Size = new System.Drawing.Size(184, 157);
            this.kluLogo.TabIndex = 1;
            this.kluLogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.16016F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.83984F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.20833F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 788);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.htmlViewer, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(187, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1110, 782);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.Controls.Add(this.kapatma, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1104, 33);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // kapatma
            // 
            this.kapatma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kapatma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kapatma.FlatAppearance.BorderSize = 0;
            this.kapatma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatma.Location = new System.Drawing.Point(1049, 1);
            this.kapatma.Margin = new System.Windows.Forms.Padding(1);
            this.kapatma.Name = "kapatma";
            this.kapatma.Size = new System.Drawing.Size(54, 31);
            this.kapatma.TabIndex = 0;
            this.kapatma.Text = "X";
            this.kapatma.UseVisualStyleBackColor = false;
            this.kapatma.Click += new System.EventHandler(this.kapatma_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 33);
            this.dataGridView1.TabIndex = 1;
            // 
            // htmlViewer
            // 
            this.htmlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlViewer.Location = new System.Drawing.Point(3, 42);
            this.htmlViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.htmlViewer.Name = "htmlViewer";
            this.htmlViewer.ScriptErrorsSuppressed = true;
            this.htmlViewer.Size = new System.Drawing.Size(1104, 737);
            this.htmlViewer.TabIndex = 1;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1300, 788);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kırklareli Üniversitesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kluLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button kluWeb;
        private System.Windows.Forms.Button kluBS;
        private System.Windows.Forms.Button BtnNasilGiderim;
        private System.Windows.Forms.Button yemekveOylama;
        private System.Windows.Forms.PictureBox kluLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button kapatma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.WebBrowser htmlViewer;
    }
}

