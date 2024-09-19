using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianoTiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Random = new Random();
        List<Label> Tiles = new List<Label>();
        int randomizetiles = 0;
        int speed = 3;
        int score = 0;
        int lifes = 3;
        bool key1col = false;
        bool key2col = false;
        bool key3col = false;
        bool key4col = false;

        bool colided = false;

        private void GenerateTiles()
        {
            // create the plink

            randomizetiles = Random.Next(1, 100);

            if (randomizetiles == 1)
            {
                Label tiles = new Label();
                tiles.Size = new Size(157, 100);
                tiles.Location = new Point(1, -87);
                tiles.BackColor = Color.Black;
                this.Controls.Add(tiles);
                Tiles.Add(tiles); // add the red plink to the list
            }
            if (randomizetiles == 2)
            {
                Label tiles = new Label();
                tiles.Size = new Size(155, 100);
                tiles.Location = new Point(170, -87);
                tiles.BackColor = Color.Black;
                this.Controls.Add(tiles);
                Tiles.Add(tiles); // add the red plink to the list
            }
            if (randomizetiles == 3)
            {
                Label tiles = new Label();
                tiles.Size = new Size(155, 100);
                tiles.Location = new Point(330, -87);
                tiles.BackColor = Color.Black;
                this.Controls.Add(tiles);
                Tiles.Add(tiles); // add the red plink to the list
            }
            if (randomizetiles == 4)
            {
                Label tiles = new Label();
                tiles.Size = new Size(155, 100);
                tiles.Location = new Point(486, -87);
                tiles.BackColor = Color.Black;
                this.Controls.Add(tiles);
                Tiles.Add(tiles); // add the red plink to the list
            }
        }

        private void tmrGrav_Tick(object sender, EventArgs e)
        {
            label1.Text = score.ToString();
            GenerateTiles();
            for (int i = 0; i < Tiles.Count; i++)
            {
                Tiles[i].Top += speed;

                // Check if the tile has missed (gone too far down the screen)
                if (Tiles[i].Top >= this.Height)
                {
                    score--;
                    lifes--;  // Lose a life if a tile goes off-screen
                    if(lifes == 0)
                    {
                        tmrGrav.Enabled = false;
                        MessageBox.Show("You lost. Your score was: "+score+" tiles.");
                        Application.Exit();
                    }
                    this.Controls.Remove(Tiles[i]);
                    Tiles[i].Dispose();
                    Tiles.RemoveAt(i);
                    i--;  // Decrement to account for removed tile

                }
            }
            CheckColission();
            ColidedWithKey();
            
        }

        private void CheckColission()
        {
            try 
            {
                for (int i = 0; i < Tiles.Count; i++) 
                {
                    if (Tiles[i].Bounds.IntersectsWith(key1.Bounds) && key1col == true)
                    {
                        score += 1;
                        colided = true;
                        this.Controls.Remove(Tiles[i]);
                        Tiles[i].Dispose();
                        Tiles.RemoveAt(i);
                        i--;  // Adjust index after removing the tile
                    }
                    else if (Tiles[i].Bounds.IntersectsWith(key2.Bounds) && key2col == true)
                    {
                        score += 1;
                        colided = true;
                        this.Controls.Remove(Tiles[i]);
                        Tiles[i].Dispose();
                        Tiles.RemoveAt(i);
                        i--;  // Adjust index after removing the tile
                    }
                    else if (Tiles[i].Bounds.IntersectsWith(key3.Bounds) && key3col == true)
                    {
                        score += 1;
                        colided = true;
                        this.Controls.Remove(Tiles[i]);
                        Tiles[i].Dispose();
                        Tiles.RemoveAt(i);
                        i--;  // Adjust index after removing the tile
                    }
                    else if (Tiles[i].Bounds.IntersectsWith(key4.Bounds) && key4col == true)
                    {
                        score += 1;
                        colided = true;
                        this.Controls.Remove(Tiles[i]);
                        Tiles[i].Dispose();
                        Tiles.RemoveAt(i);
                        i--;  // Adjust index after removing the tile
                    }
                }
            }
            catch { }
        }

       private void ColidedWithKey()
        {
            try 
            {
                for (int i = 0; i < Tiles.Count; i++) 
                {
                    
                    
                }
            }
            catch { }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool intersected = false; // Track if the tile intersected with the correct label
            if (e.KeyCode == Keys.Q)
            {
                key1col = true;
                // Check if there's a tile that intersects with key1
                foreach (Label tile in Tiles)
                {
                    if (tile.Bounds.IntersectsWith(key1.Bounds))
                    {
                        intersected = true;
                        break;
                    }
                }
                if (!intersected)
                {
                    score--;
                    label1.Text = score.ToString();
                    lifes--;
                }  // Penalize if no tile intersects
            }
            if (e.KeyCode == Keys.W)
            {
                key2col = true;
                foreach (Label tile in Tiles)
                {
                    if (tile.Bounds.IntersectsWith(key2.Bounds))
                    {
                        intersected = true;
                        break;
                    }
                }
                if (!intersected) score--; label1.Text = score.ToString(); lifes--;
            }
            if (e.KeyCode == Keys.E)
            {
                key3col = true;
                foreach (Label tile in Tiles)
                {
                    if (tile.Bounds.IntersectsWith(key3.Bounds))
                    {
                        intersected = true;
                        break;
                    }
                }
                if (!intersected) score--; label1.Text = score.ToString(); lifes--;
            }
            if (e.KeyCode == Keys.R)
            {
                key4col = true;
                foreach (Label tile in Tiles)
                {
                    if (tile.Bounds.IntersectsWith(key4.Bounds))
                    {
                        intersected = true;
                        break;
                    }
                }
                if (!intersected) score--; label1.Text = score.ToString(); lifes--;
            }

            // Make sure the score doesn't go below 0
            if (score <= 0) score = 0;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) key1col = false;
            if (e.KeyCode == Keys.W) key2col = false;
            if (e.KeyCode == Keys.E) key3col = false;
            if (e.KeyCode == Keys.R) key4col = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            this.Hide();
            newform.ShowDialog();
        }
    }
}
