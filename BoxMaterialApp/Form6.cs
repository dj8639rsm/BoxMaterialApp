using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxMaterialApp
{
    public partial class Form6 : Form
    {
        //x軸,y軸の始点の決定
        int x = 100;
        int y = 20;

        //材料の板厚
        private double box_thick = 0;
       
        //ボックスの縦、横、高さ
        private double box_height = 0;
        private double box_width = 0;
        private double box_depth = 0;

        //左上奥行、右上奥行、左下奥行、右下奥行、上背面横方向、下背面横方向、上正面横方向、下背面横方向、左背面縦方向、右背面縦方向、左正面縦方向、右正面縦方向
        private double box_lod, box_rod, box_lud, box_rud, box_row, box_ruw, box_fow, box_fuw, box_lrh, box_rrh, box_lfh, box_rfh;
        private double thick_lod, thick_rod, thick_lud, thick_rud, thick_row, thick_ruw, thick_fow, thick_fuw, thick_lrh, thick_rrh, thick_lfh, thick_rfh;
        private double wid_lod, wid_rod, wid_lud, wid_rud, wid_row, wid_ruw, wid_fow, wid_fuw, wid_lrh, wid_rrh, wid_lfh, wid_rfh;

        //左上背面、左下背面、右上背面右下背面、左上正面、左下正面、右上正面、右下正面
        private double cor_lor, cor_lur, cor_ror, cor_rur, cor_lof, cor_luf, cor_rof, cor_ruf;

        private string mat_lod, mat_rod, mat_lud, mat_rud, mat_row, mat_ruw, mat_fow, mat_fuw, mat_lrh, mat_rrh, mat_lfh, mat_rfh;


        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
        }

        public Form6()
        {
            InitializeComponent();

            //ピクチャーボックスをクリア
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ラベル、ボタンを隠す
            label1.Visible = false;
            label2.Visible = false;
            
            label4.Visible = false;
            comboBox2.Visible = false;
            button2.Visible = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;

            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;

        }

        private bool checkValue()
        {
            //テキストボックスの値をdouble型に変換してフィールドに格納
            //成功すればtrueを返す
            try
            {
                box_thick = Convert.ToDouble(comboBox1.Text);
                box_height = Convert.ToDouble(textBox1.Text);
                box_width = Convert.ToDouble(textBox2.Text);
                box_depth = Convert.ToDouble(textBox3.Text);
                return true;
            }

            //int型に変換できないときはメッセージを送信
            //falseを返す
            catch
            {
                MessageBox.Show("ボックスの板厚を選択してください", "エラー");
                return false;
            }

            //テキストボックスをクリアする。
            finally
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                //ピクチャーボックスの宣言
                var g = pictureBox3.CreateGraphics();
                g.Clear(Color.WhiteSmoke);

                //正面、背面テキストの表示
                label1.Visible = true;
                label2.Visible = true;

                //ボタン、コンボボックスを隠す
                label3.Visible = false;
                button1.Visible = false;
                comboBox1.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;

                //ボタン、ラベルの表示
                label4.Visible = true;
                comboBox2.Visible = true;
                button2.Visible = true;

                //太線の宣言
                var bold = new Pen(Color.Gray, 2);
                var bold2 = new Pen(Color.Blue, 3);

                //点線の宣言
                var dot = new Pen(Color.Gray, 2)
                {
                    DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
                };
                var dot2 = new Pen(Color.Blue, 3)
                {
                    DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
                };

                //本体フレーム（上）を表示
                g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
                g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
                g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
                g.DrawLine(bold2, x + 150, y + 50, x + 200, y + 100);

                //本体フレーム（下）を表示
                g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
                g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

                g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
                g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
                g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

                //本体フレーム（柱）を表示
                g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

                g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
                g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

                g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
                g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label4.Visible = false;
            button2.Visible = false;

            //ボタン、ラベルの表示
            label5.Visible = true;
            button3.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold2, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if(comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_lod = "なし";
                thick_lod = 0;
                wid_lod = 0;
            }
            else if(comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_lod = comboBox2.SelectedItem.ToString();
                box_lod = box_depth - (box_thick * 2) - 1;
                thick_lod = 5;
                wid_lod = 40;
            }
            else if(comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_lod = comboBox2.SelectedItem.ToString();
                box_lod = box_depth - (box_thick * 2) - 1;
                thick_lod = 6;
                wid_lod = 50;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label5.Visible = false;
            button3.Visible = false;

            //ボタン、ラベルの表示
            label6.Visible = true;
            button4.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold2, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_rod = "なし";
                thick_rod = 0;
                wid_rod = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_rod = comboBox2.SelectedItem.ToString();
                box_rod = box_depth - (box_thick * 2) - 1;
                thick_rod = 5;
                wid_rod = 40;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_rod = comboBox2.SelectedItem.ToString();
                box_rod = box_depth - (box_thick * 2) - 1;
                thick_rod = 6;
                wid_rod = 50;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label6.Visible = false;
            button4.Visible = false;

            //ボタン、ラベルの表示
            label7.Visible = true;
            button5.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot2, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_lud = "なし";
                thick_lud = 0;
                wid_lud = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_lud = comboBox2.SelectedItem.ToString();
                box_lud = box_depth - (box_thick * 2) - 1;
                thick_lud = 5;
                wid_lud = 40;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_lud = comboBox2.SelectedItem.ToString();
                box_lud = box_depth - (box_thick * 2) - 1;
                thick_lud = 6;
                wid_lud = 50;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label7.Visible = false;
            button5.Visible = false;

            //ボタン、ラベルの表示
            label8.Visible = true;
            button6.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold2, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_rud = "なし";
                thick_rud = 0;
                wid_rud = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_rud = comboBox2.SelectedItem.ToString();
                box_rud = box_depth - (box_thick * 2) - 1;
                thick_rud = 5;
                wid_rud = 40;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_rud = comboBox2.SelectedItem.ToString();
                box_rud = box_depth - (box_thick * 2) - 1;
                thick_rud = 6;
                wid_rud = 50;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label8.Visible = false;
            button6.Visible = false;

            //ボタン、ラベルの表示
            label9.Visible = true;
            button7.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold2, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot2, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_row = "なし";
                thick_row = 0;
                wid_row = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_row = comboBox2.SelectedItem.ToString();
                box_row = box_width - (box_thick * 2) - (thick_lod + thick_rod) - 1;
                thick_row = 5;
                wid_row = 40;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_row = comboBox2.SelectedItem.ToString();
                box_row = box_width - (box_thick * 2) - (thick_lod + thick_rod) - 1;
                thick_row = 6;
                wid_row = 50;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label9.Visible = false;
            button7.Visible = false;

            //ボタン、ラベルの表示
            label10.Visible = true;
            button8.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold2, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_ruw = "なし";
                thick_ruw = 0;
                wid_ruw = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_ruw = comboBox2.SelectedItem.ToString();
                box_ruw = box_width - (box_thick * 2) - (thick_lud + thick_rud) - 1;
                thick_ruw = 5;
                wid_ruw = 40;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_ruw = comboBox2.SelectedItem.ToString();
                box_ruw = box_width - (box_thick * 2) - (thick_lud + thick_rud) - 1;
                thick_ruw = 6;
                wid_ruw = 50;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label10.Visible = false;
            button8.Visible = false;

            //ボタン、ラベルの表示
            label11.Visible = true;
            button9.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold2, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_fow = "なし";
                thick_fow = 0;
                wid_fow = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_fow = comboBox2.SelectedItem.ToString();
                box_fow = box_width - (box_thick * 2) - (thick_lod + thick_rod) - 1;
                thick_fow = 5;
                wid_fow = 40;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_fow = comboBox2.SelectedItem.ToString();
                box_fow = box_width - (box_thick * 2) - (thick_lod + thick_rod) - 1;
                thick_fow = 6;
                wid_fow = 50;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label11.Visible = false;
            button9.Visible = false;

            //ボタン、ラベルの表示
            label12.Visible = true;
            button10.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold2, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_fuw = "なし";
                thick_fuw = 0;
                wid_fuw = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                mat_fuw = comboBox2.SelectedItem.ToString();
                box_fuw = box_width - (box_thick * 2) - (thick_lud + thick_rud) - 1;
                thick_fuw = 5;
                wid_fuw = 40;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_fuw = comboBox2.SelectedItem.ToString();
                box_fuw = box_width - (box_thick * 2) - (thick_lud + thick_rud) - 1;
                thick_fuw = 6;
                wid_fuw = 50;
            }
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label12.Visible = false;
            button10.Visible = false;

            //ボタン、ラベルの表示
            label13.Visible = true;
            button11.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold2, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot2, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_lrh = "なし";
                thick_lrh = 0;
                wid_lrh = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                if(mat_lod == "なし" && mat_row == "なし")
                {
                    cor_lor = 0;
                }
                if (mat_lod != "なし" && mat_row == "なし")
                {
                    cor_lor = thick_lod;
                }
                if (mat_lod == "なし" && mat_row != "なし")
                {
                    cor_lor = thick_row;
                }
                if (mat_lod != "なし" && mat_row != "なし")
                {
                    if(wid_lod < wid_row)
                    {
                        cor_lor = wid_lod;
                    }
                    else
                    {
                        cor_lor = wid_row;
                    }
                }

                if (mat_lud == "なし" && mat_ruw == "なし")
                {
                    cor_lur = 0;
                }
                if (mat_lud != "なし" && mat_ruw == "なし")
                {
                    cor_lur = thick_lud;
                }
                if (mat_lud == "なし" && mat_ruw != "なし")
                {
                    cor_lur = thick_ruw;
                }
                if (mat_lud != "なし" && mat_ruw != "なし")
                {
                    if (wid_lud < wid_ruw)
                    {
                        cor_lur = wid_lud;
                    }
                    else
                    {
                        cor_lur = wid_ruw;
                    }
                }
                mat_lrh = comboBox2.SelectedItem.ToString();
                box_lrh = box_height - (box_thick * 2) - (cor_lor + cor_lur) - 1;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_lrh = comboBox2.SelectedItem.ToString();
                box_lrh = box_height - (box_thick * 2) - (cor_lor + cor_lur) - 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label13.Visible = false;
            button11.Visible = false;

            //ボタン、ラベルの表示
            label14.Visible = true;
            button12.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold2, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_rrh = "なし";
                thick_rrh = 0;
                wid_rrh = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                if (mat_rod == "なし" && mat_row == "なし")
                {
                    cor_ror = 0;
                }
                if (mat_rod != "なし" && mat_row == "なし")
                {
                    cor_ror = thick_rod;
                }
                if (mat_rod == "なし" && mat_row != "なし")
                {
                    cor_ror = thick_row;
                }
                if (mat_rod != "なし" && mat_row != "なし")
                {
                    if (wid_rod < wid_row)
                    {
                        cor_ror = wid_rod;
                    }
                    else
                    {
                        cor_ror = wid_row;
                    }
                }

                if (mat_rud == "なし" && mat_ruw == "なし")
                {
                    cor_rur = 0;
                }
                if (mat_rud != "なし" && mat_ruw == "なし")
                {
                    cor_rur = thick_lud;
                }
                if (mat_rud == "なし" && mat_ruw != "なし")
                {
                    cor_rur = thick_ruw;
                }
                if (mat_rud != "なし" && mat_ruw != "なし")
                {
                    if (wid_rud < wid_ruw)
                    {
                        cor_rur = wid_rud;
                    }
                    else
                    {
                        cor_rur = wid_ruw;
                    }
                }
                mat_rrh = comboBox2.SelectedItem.ToString();
                box_rrh = box_height - (box_thick * 2) - (cor_ror + cor_rur) - 1;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_rrh = comboBox2.SelectedItem.ToString();
                box_rrh = box_height - (box_thick * 2) - (cor_ror + cor_rur) - 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label14.Visible = false;
            button12.Visible = false;

            //ボタン、ラベルの表示
            label15.Visible = true;
            button13.Visible = true;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            //本体フレーム（上）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 350, y + 50);
            g.DrawLine(bold, x + 350, y + 50, x + 400, y + 100);
            g.DrawLine(bold, x + 200, y + 100, x + 400, y + 100);
            g.DrawLine(bold, x + 150, y + 50, x + 200, y + 100);

            //本体フレーム（下）を表示
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 200);
            g.DrawLine(dot, x + 200, y + 200, x + 350, y + 200);

            g.DrawLine(dot, x + 350, y + 200, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 250, x + 400, y + 250);
            g.DrawLine(bold, x + 150, y + 200, x + 200, y + 250);

            //本体フレーム（柱）を表示
            g.DrawLine(bold, x + 150, y + 50, x + 150, y + 200);

            g.DrawLine(bold, x + 350, y + 50, x + 350, y + 100);
            g.DrawLine(dot, x + 350, y + 100, x + 350, y + 200);

            g.DrawLine(bold2, x + 400, y + 100, x + 400, y + 250);
            g.DrawLine(bold, x + 200, y + 100, x + 200, y + 250);

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_lfh = "なし";
                thick_lfh = 0;
                wid_lfh = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                if (mat_lod == "なし" && mat_fow == "なし")
                {
                    cor_lof = 0;
                }
                if (mat_lod != "なし" && mat_fow == "なし")
                {
                    cor_lof = thick_lod;
                }
                if (mat_lod == "なし" && mat_fow != "なし")
                {
                    cor_lof = thick_fow;
                }
                if (mat_lod != "なし" && mat_fow != "なし")
                {
                    if (wid_lod < wid_fow)
                    {
                        cor_lof = wid_lod;
                    }
                    else
                    {
                        cor_lof = wid_fow;
                    }
                }

                if (mat_lud == "なし" && mat_fuw == "なし")
                {
                    cor_luf = 0;
                }
                if (mat_lud != "なし" && mat_fuw == "なし")
                {
                    cor_luf = thick_lud;
                }
                if (mat_lud == "なし" && mat_fuw != "なし")
                {
                    cor_luf = thick_fuw;
                }
                if (mat_lud != "なし" && mat_fuw != "なし")
                {
                    if (wid_lud < wid_fuw)
                    {
                        cor_luf = wid_lud;
                    }
                    else
                    {
                        cor_luf = wid_fuw;
                    }
                }
                mat_lfh = comboBox2.SelectedItem.ToString();
                box_lfh = box_height - (box_thick * 2) - (cor_lof + cor_luf) - 1;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_lfh = comboBox2.SelectedItem.ToString();
                box_lfh = box_height - (box_thick * 2) - (cor_lof + cor_luf) - 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //ピクチャーボックスの宣言
            var g = pictureBox3.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタン、コンボボックスを隠す
            label15.Visible = false;
            button13.Visible = false;

            //太線の宣言
            var bold = new Pen(Color.Gray, 2);
            var bold2 = new Pen(Color.Blue, 3);

            //点線の宣言
            var dot = new Pen(Color.Gray, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            var dot2 = new Pen(Color.Blue, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

            if (comboBox2.SelectedItem.ToString() == "なし")
            {
                mat_rfh = "なし";
                thick_rfh = 0;
                wid_rfh = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "５×４０アングル")
            {
                if (mat_rod == "なし" && mat_fow == "なし")
                {
                    cor_rof = 0;
                }
                if (mat_rod != "なし" && mat_fow == "なし")
                {
                    cor_rof = thick_rod;
                }
                if (mat_rod == "なし" && mat_fow != "なし")
                {
                    cor_rof = thick_fow;
                }
                if (mat_rod != "なし" && mat_fow != "なし")
                {
                    if (wid_rod < wid_fow)
                    {
                        cor_rof = wid_rod;
                    }
                    else
                    {
                        cor_rof = wid_fow;
                    }
                }

                if (mat_rud == "なし" && mat_fuw == "なし")
                {
                    cor_ruf = 0;
                }
                if (mat_rud != "なし" && mat_fuw == "なし")
                {
                    cor_ruf = thick_rud;
                }
                if (mat_rud == "なし" && mat_fuw != "なし")
                {
                    cor_ruf = thick_fuw;
                }
                if (mat_rud != "なし" && mat_fuw != "なし")
                {
                    if (wid_rud < wid_fuw)
                    {
                        cor_ruf = wid_rud;
                    }
                    else
                    {
                        cor_ruf = wid_fuw;
                    }
                }
                mat_rfh = comboBox2.SelectedItem.ToString();
                box_rfh = box_height - (box_thick * 2) - (cor_rof + cor_ruf) - 1;
            }
            else if (comboBox2.SelectedItem.ToString() == "６×５０アングル")
            {
                mat_rfh = comboBox2.SelectedItem.ToString();
                box_rfh = box_height - (box_thick * 2) - (cor_rof + cor_ruf) - 1;
            }

            MessageBox.Show("　左側面 上方向　" + mat_lod + "　L=　" + (int)box_lod + Environment.NewLine +
                            "　右側面 上方向　" + mat_rod + "　L=　" + (int)box_rod + Environment.NewLine +
                            "　左側面 下方向　" + mat_lud + "　L=　" + (int)box_lud + Environment.NewLine +
                            "　右側面 下方向　" + mat_rud + "　L=　" + (int)box_rud + Environment.NewLine +
                            "　上背面 横方向　" + mat_row + "　L=　" + (int)box_row + Environment.NewLine +
                            "　下背面 横方向　" + mat_ruw + "　L=　" + (int)box_ruw + Environment.NewLine +
                            "　上正面 横方向　" + mat_fow + "　L=　" + (int)box_fow + Environment.NewLine +
                            "　上正面 横方向　" + mat_fuw + "　L=　" + (int)box_fuw + Environment.NewLine +
                            "　左背面 縦方向　" + mat_lrh + "　L=　" + (int)box_lrh + Environment.NewLine +
                            "　右背面 縦方向　" + mat_rrh + "　L=　" + (int)box_rrh + Environment.NewLine +
                            "　左正面 縦方向　" + mat_lfh + "　L=　" + (int)box_lfh + Environment.NewLine +
                            "　右正面 縦方向　" + mat_rfh + "　L=　" + (int)box_rfh ,
                            "成功");
        }
    }
}
