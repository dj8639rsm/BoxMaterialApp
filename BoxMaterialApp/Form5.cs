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
    public partial class Form5 : Form
    {
        //x軸,y軸の始点の決定
        int x = 100;
        int y = 20;

        //ボックスの高さ、テキストボックス１
        private double box_h = 0;
        //ボックスと扉の下面の隙間、テキストボックス２
        private double gap = 0;
        //扉の高さ、テキストボックス３
        private double door_h = 0;
        //扉下面からハンドル上面までの高さ、テキストボックス４
        private double handle_h = 0;
        //上面ガーター部の曲げの値、テキストボックス５
        private double garter_over = 0;
        //下面ガーター部の曲げの値、テキストボックス６
        private double garter_under = 0;

        public Form5()
        {
            InitializeComponent();

            //ピクチャーボックスをクリア
            var g = pictureBox2.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //ボタンを隠す
            button2.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;

            button3.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;

            button4.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;

            button5.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;

            button6.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;

            button7.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;

            button8.Visible = false;
            comboBox1.Visible = false;
            label8.Visible = false;
        }

        private bool checkValue()
        {
            //テキストボックスの値をdouble型に変換してフィールドに格納
            //成功すればtrueを返す
            try
            {
                box_h = Convert.ToDouble(textBox1.Text);
                return true;
            }

            //int型に変換できないときはメッセージを送信
            //falseを返す
            catch
            {
                MessageBox.Show("半角数字で入力してください。", "エラー");
                return false;
            }

            //テキストボックスをクリアする。
            finally
            {
                textBox1.Clear();
            }
        }

        private bool checkValue2()
        {
            //テキストボックスの値をdouble型に変換してフィールドに格納
            //成功すればtrueを返す
            try
            {
                gap = Convert.ToDouble(textBox2.Text);
                return true;
            }

            //int型に変換できないときはメッセージを送信
            //falseを返す
            catch
            {
                MessageBox.Show("半角数字で入力してください。", "エラー");
                return false;
            }

            //テキストボックスをクリアする。
            finally
            {
                textBox2.Clear();
            }
        }

        private bool checkValue3()
        {
            //テキストボックスの値をdouble型に変換してフィールドに格納
            //成功すればtrueを返す
            try
            {
                door_h = Convert.ToDouble(textBox3.Text);
                return true;
            }

            //int型に変換できないときはメッセージを送信
            //falseを返す
            catch
            {
                MessageBox.Show("半角数字で入力してください。", "エラー");
                return false;
            }

            //テキストボックスをクリアする。
            finally
            {
                textBox3.Clear();
            }
        }

        private bool checkValue4()
        {
            //テキストボックスの値をdouble型に変換してフィールドに格納
            //成功すればtrueを返す
            try
            {
                handle_h = Convert.ToDouble(textBox4.Text);
                return true;
            }

            //int型に変換できないときはメッセージを送信
            //falseを返す
            catch
            {
                MessageBox.Show("半角数字で入力してください。", "エラー");
                return false;
            }

            //テキストボックスをクリアする。
            finally
            {
                textBox4.Clear();
            }
        }

        private bool checkValue5()
        {
            //テキストボックスの値をdouble型に変換してフィールドに格納
            //成功すればtrueを返す
            try
            {
                garter_over = Convert.ToDouble(textBox5.Text);
                return true;
            }

            //int型に変換できないときはメッセージを送信
            //falseを返す
            catch
            {
                MessageBox.Show("半角数字で入力してください。", "エラー");
                return false;
            }

            //テキストボックスをクリアする。
            finally
            {
                textBox5.Clear();
            }
        }
        private bool checkValue6()
        {
            //テキストボックスの値をdouble型に変換してフィールドに格納
            //成功すればtrueを返す
            try
            {
                garter_under = Convert.ToDouble(textBox6.Text);
                return true;
            }

            //int型に変換できないときはメッセージを送信
            //falseを返す
            catch
            {
                MessageBox.Show("半角数字で入力してください。", "エラー");
                return false;
            }

            //テキストボックスをクリアする。
            finally
            {
                textBox6.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ボタンを隠す
            button1.Visible = false;

            //ボタンの表示
            button2.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;

            //カーソルのフォーカス
            textBox1.Focus();

            //ピクチャーボックスの宣言
            var g = pictureBox2.CreateGraphics();
            g.Clear(Color.WhiteSmoke);

            //太線の宣言
            var bold = new Pen(Color.Black, 2);

            //本体フレーム（上）を表示
            var points1 = new Point[5];
            points1[0] = new Point(x, y);
            points1[1] = new Point((x + 50), y);
            points1[2] = new Point((x + 50), (y + 50));
            points1[3] = new Point((x + 75), (y + 50));
            points1[4] = new Point((x + 75), (y + 25));
            g.DrawLines(bold, points1);

            //本体フレーム（下）を表示
            var points2 = new Point[5];
            points2[0] = new Point(x, (y + 300));
            points2[1] = new Point((x + 50), (y + 300));
            points2[2] = new Point((x + 50), (y + 250));
            points2[3] = new Point((x + 75), (y + 250));
            points2[4] = new Point((x + 75), (y + 275));
            g.DrawLines(bold, points2);

            //扉表示
            var points3 = new Point[4];
            points3[0] = new Point((x + 60), (y + 10));
            points3[1] = new Point((x + 85), (y + 10));
            points3[2] = new Point((x + 85), (y + 290));
            points3[3] = new Point((x + 60), (y + 290));
            g.DrawLines(bold, points3);

            //縦線の寸法線を表示
            g.DrawLine(Pens.Blue, (x + 95), y, (x + 140), y);
            g.DrawLine(Pens.Blue, (x + 130), y, (x + 130), (y + 300));
            g.DrawLine(Pens.Blue, (x + 95), (y + 300), (x + 140), (y + 300));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                //ボタンを隠す
                button2.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;

                //ボタンの表示
                button3.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;

                //カーソルのフォーカス
                textBox2.Focus();

                //ピクチャーボックスをクリア
                var g = pictureBox2.CreateGraphics();
                g.Clear(Color.WhiteSmoke);

                //太線の宣言
                var bold = new Pen(Color.Black, 2);

                //本体フレーム（下）を表示
                var points2 = new Point[5];
                points2[0] = new Point(x, (y + 200));
                points2[1] = new Point((x + 50), (y + 200));
                points2[2] = new Point((x + 50), (y + 150));
                points2[3] = new Point((x + 75), (y + 150));
                points2[4] = new Point((x + 75), (y + 175));
                g.DrawLines(bold, points2);

                //扉表示
                var points3 = new Point[3];
                points3[0] = new Point((x + 85), (y + 50));
                points3[1] = new Point((x + 85), (y + 190));
                points3[2] = new Point((x + 60), (y + 190));
                g.DrawLines(bold, points3);

                //縦線の寸法線を表示
                g.DrawLine(Pens.Blue, (x + 95), (y + 190), (x + 140), (y + 190));
                g.DrawLine(Pens.Blue, (x + 130), (y + 190), (x + 130), (y + 200));
                g.DrawLine(Pens.Blue, (x + 95), (y + 200), (x + 140), (y + 200));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkValue2())
            {
                //ボタンを隠す
                button3.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;

                //ボタンの表示
                button4.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;

                //カーソルのフォーカス
                textBox3.Focus();

                //ピクチャーボックスの宣言
                var g = pictureBox2.CreateGraphics();
                g.Clear(Color.WhiteSmoke);

                //太線の宣言
                var bold = new Pen(Color.Black, 2);

                //本体フレーム（上）を表示
                var points1 = new Point[5];
                points1[0] = new Point(x, y);
                points1[1] = new Point((x + 50), y);
                points1[2] = new Point((x + 50), (y + 50));
                points1[3] = new Point((x + 75), (y + 50));
                points1[4] = new Point((x + 75), (y + 25));
                g.DrawLines(bold, points1);

                //本体フレーム（下）を表示
                var points2 = new Point[5];
                points2[0] = new Point(x, (y + 300));
                points2[1] = new Point((x + 50), (y + 300));
                points2[2] = new Point((x + 50), (y + 250));
                points2[3] = new Point((x + 75), (y + 250));
                points2[4] = new Point((x + 75), (y + 275));
                g.DrawLines(bold, points2);

                //扉表示
                var points3 = new Point[4];
                points3[0] = new Point((x + 60), (y + 10));
                points3[1] = new Point((x + 85), (y + 10));
                points3[2] = new Point((x + 85), (y + 290));
                points3[3] = new Point((x + 60), (y + 290));
                g.DrawLines(bold, points3);

                //縦線の寸法線を表示
                g.DrawLine(Pens.Blue, (x + 95), (y + 10), (x + 140), (y + 10));
                g.DrawLine(Pens.Blue, (x + 130), (y + 10), (x + 130), (y + 290));
                g.DrawLine(Pens.Blue, (x + 95), (y + 290), (x + 140), (y + 290));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkValue3())
            {
                //ボタンを隠す
                button4.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;

                //ボタンの表示
                button5.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;

                //カーソルのフォーカス
                textBox4.Focus();

                //ピクチャーボックスの宣言
                var g = pictureBox2.CreateGraphics();
                g.Clear(Color.WhiteSmoke);

                //太線の宣言
                var bold = new Pen(Color.Black, 2);

                //点線の宣言
                var dot = new Pen(Color.Blue)
                {
                    DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
                };

                //扉を表示
                g.DrawRectangle(bold, x, (y + 10), 80, 280);
                g.DrawRectangle(Pens.Black, (x + 10), (y + 130), 10, 40);

                //縦線の寸法線を表示
                g.DrawLine(Pens.Blue, (x + 80), (y + 130), (x + 120), (y + 130));
                g.DrawLine(Pens.Blue, (x + 110), (y + 130), (x + 110), (y + 290));
                g.DrawLine(Pens.Blue, (x + 80), (y + 290), (x + 120), (y + 290));

                //寸法線の点線を表示
                g.DrawLine(dot, (x + 20), (y + 130), (x + 120), (y + 130));

                //扉を表示
                g.DrawRectangle(bold, (x + 180), (y + 10), 80, 280);
                g.DrawEllipse(Pens.Black, (x + 190), (y + 140), 5, 5);
                g.DrawEllipse(Pens.Black, (x + 188), (y + 147), 10, 10);
                g.DrawEllipse(Pens.Black, (x + 190), (y + 160), 5, 5);

                //縦線の寸法線を表示
                g.DrawLine(Pens.Blue, (x + 260), (y + 140), (x + 300), (y + 140));
                g.DrawLine(Pens.Blue, (x + 290), (y + 140), (x + 290), (y + 290));
                g.DrawLine(Pens.Blue, (x + 260), (y + 290), (x + 300), (y + 290));

                //寸法線の点線を表示
                g.DrawLine(dot, (x + 195), (y + 140), (x + 300), (y + 140));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkValue4())
            {
                //ボタンを隠す
                button5.Visible = false;
                label4.Visible = false;
                textBox4.Visible = false;

                //ボタンの表示
                button6.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;

                //カーソルのフォーカス
                textBox5.Focus();

                //ピクチャーボックスをクリア
                var g = pictureBox2.CreateGraphics();
                g.Clear(Color.WhiteSmoke);

                //太線の宣言
                var bold = new Pen(Color.Black, 2);

                //本体フレーム（下）を表示
                var points2 = new Point[5];
                points2[0] = new Point(x, (y + 150));
                points2[1] = new Point((x + 50), (y + 150));
                points2[2] = new Point((x + 50), (y + 200));
                points2[3] = new Point((x + 75), (y + 200));
                points2[4] = new Point((x + 75), (y + 175));
                g.DrawLines(bold, points2);

                //縦線の寸法線を表示
                g.DrawLine(Pens.Blue, (x + 95), (y + 150), (x + 140), (y + 150));
                g.DrawLine(Pens.Blue, (x + 130), (y + 150), (x + 130), (y + 200));
                g.DrawLine(Pens.Blue, (x + 95), (y + 200), (x + 140), (y + 200));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkValue5())
            {
                //ボタンを隠す
                button6.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;

                //ボタンの表示
                button7.Visible = true;
                label6.Visible = true;
                textBox6.Visible = true;

                //カーソルのフォーカス
                textBox6.Focus();

                //ピクチャーボックスをクリア
                var g = pictureBox2.CreateGraphics();
                g.Clear(Color.WhiteSmoke);

                //太線の宣言
                var bold = new Pen(Color.Black, 2);

                //本体フレーム（下）を表示
                var points2 = new Point[5];
                points2[0] = new Point(x, (y + 200));
                points2[1] = new Point((x + 50), (y + 200));
                points2[2] = new Point((x + 50), (y + 150));
                points2[3] = new Point((x + 75), (y + 150));
                points2[4] = new Point((x + 75), (y + 175));
                g.DrawLines(bold, points2);

                //縦線の寸法線を表示
                g.DrawLine(Pens.Blue, (x + 95), (y + 150), (x + 140), (y + 150));
                g.DrawLine(Pens.Blue, (x + 130), (y + 150), (x + 130), (y + 200));
                g.DrawLine(Pens.Blue, (x + 95), (y + 200), (x + 140), (y + 200));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkValue6())
            {
                //ピクチャーボックスをクリア
                var g = pictureBox2.CreateGraphics();
                g.Clear(Color.WhiteSmoke);

                //ボタンを隠す
                button7.Visible = false;
                label6.Visible = false;
                textBox6.Visible = false;

                //コンボボックスの表示
                comboBox1.Visible = true;
                button8.Visible = true;
                label8.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            label7.Text = selectedItem;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("ハンドルを選択してください", "エラー");
            }
            else if ((string)comboBox1.SelectedItem == "A-481-5-1")
            {
                double rod_over = 0;
                double rod_under = 0;

                double gat_over = 0;
                double gat_under = 0;

                rod_over = door_h - handle_h + 13 - 20 + 35; 
                rod_under = handle_h - 13 - 20 + 35;

                gat_over = garter_over + 4.6 - (box_h - door_h - gap) + 13;
                gat_under = garter_under + 4.6 - gap + 13;

                rod_over = rod_over - gat_over;
                rod_under = rod_under - gat_under;

                MessageBox.Show(Convert.ToString(rod_over) + Environment.NewLine + Convert.ToString(rod_under), "RESULT");
            }
        }
    }
}
