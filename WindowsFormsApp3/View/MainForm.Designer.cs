
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.Controller;

namespace PhoneContacts.View
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addContact_Button = new System.Windows.Forms.Button();
            this.update_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addContact_Button
            // 
            this.addContact_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addContact_Button.Location = new System.Drawing.Point(250, 300);
            this.addContact_Button.Name = "addContact_Button";
            this.addContact_Button.Size = new System.Drawing.Size(50, 50);
            this.addContact_Button.TabIndex = 0;
            this.addContact_Button.Text = "+";
            this.addContact_Button.Click += new System.EventHandler(this.addContact_Button_Click);
            // 
            // update_Button
            // 
            this.update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.update_Button.Location = new System.Drawing.Point(194, 300);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(50, 50);
            this.update_Button.TabIndex = 1;
            this.update_Button.Text = "U";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 440);
            this.Controls.Add(this.addContact_Button);
            this.Controls.Add(this.update_Button);
            this.Name = "Form1";
            this.Text = "Контакты";
            this.ResumeLayout(false);

        }
        private Button addContact_Button;
        private Button update_Button;
        #endregion
    }
}

