
namespace WindowsFormsApp1
{
    partial class frm1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.btnHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCallForm = new System.Windows.Forms.Button();
            this.btnStaticInstance = new System.Windows.Forms.Button();
            this.btnStaticMethod = new System.Windows.Forms.Button();
            this.btnFormHello = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHello.Location = new System.Drawing.Point(20, 140);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(86, 41);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(139, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 41);
            this.txtName.TabIndex = 2;
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHi.Location = new System.Drawing.Point(142, 140);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(86, 41);
            this.btnHi.TabIndex = 3;
            this.btnHi.Text = "Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.button_click);
            // 
            // btnProperty
            // 
            this.btnProperty.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperty.Location = new System.Drawing.Point(276, 140);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(141, 41);
            this.btnProperty.TabIndex = 4;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.button_click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(261, 248);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(183, 41);
            this.btnEnroll.TabIndex = 5;
            this.btnEnroll.Text = "Enroll Event";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.button_click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(29, 248);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(183, 41);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "btn test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnCallForm
            // 
            this.btnCallForm.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallForm.Location = new System.Drawing.Point(29, 295);
            this.btnCallForm.Name = "btnCallForm";
            this.btnCallForm.Size = new System.Drawing.Size(183, 41);
            this.btnCallForm.TabIndex = 7;
            this.btnCallForm.Text = "NewForm";
            this.btnCallForm.UseVisualStyleBackColor = true;
            this.btnCallForm.Click += new System.EventHandler(this.button_click);
            // 
            // btnStaticInstance
            // 
            this.btnStaticInstance.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaticInstance.Location = new System.Drawing.Point(29, 357);
            this.btnStaticInstance.Name = "btnStaticInstance";
            this.btnStaticInstance.Size = new System.Drawing.Size(248, 41);
            this.btnStaticInstance.TabIndex = 8;
            this.btnStaticInstance.Text = "static vs instance";
            this.btnStaticInstance.UseVisualStyleBackColor = true;
            this.btnStaticInstance.Click += new System.EventHandler(this.button_click);
            // 
            // btnStaticMethod
            // 
            this.btnStaticMethod.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaticMethod.Location = new System.Drawing.Point(29, 426);
            this.btnStaticMethod.Name = "btnStaticMethod";
            this.btnStaticMethod.Size = new System.Drawing.Size(339, 41);
            this.btnStaticMethod.TabIndex = 9;
            this.btnStaticMethod.Text = "static vs instance Method";
            this.btnStaticMethod.UseVisualStyleBackColor = true;
            this.btnStaticMethod.Click += new System.EventHandler(this.button_click);
            // 
            // btnFormHello
            // 
            this.btnFormHello.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormHello.Location = new System.Drawing.Point(20, 187);
            this.btnFormHello.Name = "btnFormHello";
            this.btnFormHello.Size = new System.Drawing.Size(150, 41);
            this.btnFormHello.TabIndex = 10;
            this.btnFormHello.Text = "Hello this";
            this.btnFormHello.UseVisualStyleBackColor = true;
            this.btnFormHello.Click += new System.EventHandler(this.button_click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(364, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 41);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button_click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 499);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFormHello);
            this.Controls.Add(this.btnStaticMethod);
            this.Controls.Add(this.btnStaticInstance);
            this.Controls.Add(this.btnCallForm);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.button_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCallForm;
        private System.Windows.Forms.Button btnStaticInstance;
        private System.Windows.Forms.Button btnStaticMethod;
        private System.Windows.Forms.Button btnFormHello;
        private System.Windows.Forms.Button btnClose;
    }
}

