namespace BaldiEncryptedText
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Decode_Copy_Butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Decode_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Decode_Text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Encode_Copy_Butt = new System.Windows.Forms.Button();
            this.Encode_Output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Encode_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Decode_Copy_Butt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Decode_Output);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Decode_Text);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Decode_Copy_Butt
            // 
            resources.ApplyResources(this.Decode_Copy_Butt, "Decode_Copy_Butt");
            this.Decode_Copy_Butt.Name = "Decode_Copy_Butt";
            this.Decode_Copy_Butt.UseVisualStyleBackColor = true;
            this.Decode_Copy_Butt.Click += new System.EventHandler(this.Decode_Copy_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Decode_Output
            // 
            resources.ApplyResources(this.Decode_Output, "Decode_Output");
            this.Decode_Output.Name = "Decode_Output";
            this.Decode_Output.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Decode_Text
            // 
            resources.ApplyResources(this.Decode_Text, "Decode_Text");
            this.Decode_Text.Name = "Decode_Text";
            this.Decode_Text.TextChanged += new System.EventHandler(this.Decode_Text_Changed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Encode_Copy_Butt);
            this.groupBox2.Controls.Add(this.Encode_Output);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Encode_Text);
            this.groupBox2.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Encode_Copy_Butt
            // 
            resources.ApplyResources(this.Encode_Copy_Butt, "Encode_Copy_Butt");
            this.Encode_Copy_Butt.Name = "Encode_Copy_Butt";
            this.Encode_Copy_Butt.UseVisualStyleBackColor = true;
            this.Encode_Copy_Butt.Click += new System.EventHandler(this.Encode_Copy);
            // 
            // Encode_Output
            // 
            resources.ApplyResources(this.Encode_Output, "Encode_Output");
            this.Encode_Output.Name = "Encode_Output";
            this.Encode_Output.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Encode_Text
            // 
            resources.ApplyResources(this.Encode_Text, "Encode_Text");
            this.Encode_Text.Name = "Encode_Text";
            this.Encode_Text.TextChanged += new System.EventHandler(this.Encode_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Really);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Decode_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Decode_Output;
        private System.Windows.Forms.Button Decode_Copy_Butt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Encode_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Encode_Output;
        private System.Windows.Forms.Button Encode_Copy_Butt;
    }
}

