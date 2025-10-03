using Inlämningsuppgift2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2
{
    public partial class Form3Game : Form
    {
        public static Form3Game form3GameInstance { get; private set; }
        
        public Form3Game()
        {
            InitializeComponent();
            form3GameInstance = this;
            panelAI.BackColor = Color.FromArgb(64, Color.Black);
            panelUser.BackColor = Color.FromArgb(64, Color.Black);

            Game.Instance.player.OnAction += UpdateActionUI;
            Game.Instance.ai.OnActionAI += UpdateActionUIAI;
            Game.Instance.player.OnReload += UpdateReload;
            Game.Instance.player.OnShot += UpdateShoot;
            Game.Instance.ai.OnReloadAI += UpdateReloadAI;
            Game.Instance.ai.OnShotAI += UpdateShootAI;
            Game.Instance.player.OnRemoveLife += UpdateRemoveLife;
            Game.Instance.ai.OnRemoveLifeAI += UpdateRemoveLifeAI;
            Game.Instance.OnPlay += UpdateUIOnPlay;
            Game.Instance.player.OnSetLabelText += UpdateLabetText;
            Game.Instance.ai.OnSetLabelTextAI += UpdateLabetTextAI;
            Game.Instance.player.OnBlockShootBtn += EnableShootButton;
            Game.Instance.player.OnBlockReloadBtn += EnableReloadButton;
            Game.Instance.OnPlayInfo += UpdateInfoText;
            ResetOnStart();
        }

        public void ResetOnStart()
        {
            InitUIAtStart();
            EnablePlayButton(false);
            UpdateUIOnPlay(false);
            EnableShootButton(false);
            EnableShotgunButton(false);
            UpdateLabetText("");
            UpdateLabetTextAI("");
            UpdateInfoText("Choose your action and press Play!");
        }

        private void buttonPlayTurn_Click(object sender, EventArgs e)
        {
            if (Game.Instance.Play()) EnablePlayButton(false);
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            if (Game.Instance.player.SetAction(ActionType.Shoot)) EnablePlayButton(true);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (Game.Instance.player.SetAction(ActionType.Reload)) EnablePlayButton(true);
        }

        private void buttonDefend_Click(object sender, EventArgs e)
        {
            if (Game.Instance.player.SetAction(ActionType.Defend)) EnablePlayButton(true);
        }

        public void UpdateActionUI(ActionType action)
        {
            switch (action)
            {
                case ActionType.Shoot:
                    pictureBoxCurrentDraw.Image = Properties.Resources.shoot;
                    break;
                case ActionType.Reload:
                    pictureBoxCurrentDraw.Image = Properties.Resources.reload;
                    break;
                case ActionType.Defend:
                    pictureBoxCurrentDraw.Image = Properties.Resources.block;
                    break;
                case ActionType.Shotgun:
                    pictureBoxCurrentDraw.Image = Properties.Resources.superShotgun;
                    break;
            }
        }
        public void UpdateActionUIAI(ActionType action)
        {
            switch (action)
            {
                case ActionType.Shoot:
                    pictureBoxCurrentDrawAI.Image = Properties.Resources.shoot;
                    break;
                case ActionType.Reload:
                    pictureBoxCurrentDrawAI.Image = Properties.Resources.reload;
                    break;
                case ActionType.Defend:
                    pictureBoxCurrentDrawAI.Image = Properties.Resources.block;
                    break;
                case ActionType.Shotgun:
                    pictureBoxCurrentDrawAI.Image = Properties.Resources.superShotgun;
                    break;
            }
        }

        public void InitUIAtStart()
        {
            foreach (Control ctrl in ammoPanel.Controls)
            {
                if (ctrl is PictureBox pb)
                {
                    pb.Visible = false;
                }
            }
            foreach (Control ctrl in ammoPanelAI.Controls)
            {
                if (ctrl is PictureBox pb)
                {
                    pb.Visible = false;
                }
            }
            foreach (Control ctrl in lifePanel.Controls)
            {
                if (ctrl is PictureBox pb)
                {
                    pb.Visible = true;
                }
            }
            foreach (Control ctrl in lifePanelAI.Controls)
            {
                if (ctrl is PictureBox pb)
                {
                    pb.Visible = true;
                }
            }
        }

        public void UpdateReload()
        {
            for (int i = ammoPanel.Controls.Count - 1; i >= 0; i--)
            {
                if (ammoPanel.Controls[i] is PictureBox pb && !pb.Visible)
                {
                    pb.Visible = true;
                    break;
                }
            }
        }
        public void UpdateReloadAI()
        {
            for (int i = ammoPanelAI.Controls.Count - 1; i >= 0; i--)
            {
                if (ammoPanelAI.Controls[i] is PictureBox pb && !pb.Visible)
                {
                    pb.Visible = true;
                    break;
                }
            }
        }

        private void UpdateLabetText(string text)
        {
            labelAction.Text = text;
        }
        private void UpdateLabetTextAI(string text)
        {
            labelActionAI.Text = text;
        }

        public void UpdateShoot(int ammoShots)
        {
            for (int i = 0; i < ammoShots; i++)
            {
                for (int j = ammoPanel.Controls.Count - 1; j >= 0; j--)
                {
                    if (ammoPanel.Controls[j] is PictureBox pb && pb.Visible)
                    {
                        pb.Visible = false;
                        break;
                    }
                }
            }
        }
        public void UpdateShootAI(int ammoShots)
        {
            for (int i = 0; i < ammoShots; i++)
            {
                for (int j = ammoPanelAI.Controls.Count - 1; j >= 0; j--)
                {
                    if (ammoPanelAI.Controls[j] is PictureBox pb && pb.Visible)
                    {
                        pb.Visible = false;
                        break;
                    }
                }
            }
        }

        public void UpdateRemoveLife()
        {
            for (int i = lifePanel.Controls.Count - 1; i >= 0; i--)
            {
                if (lifePanel.Controls[i] is PictureBox pb && pb.Visible)
                {
                    pb.Visible = false;
                    break;
                }
            }
            ShakeControl();
        }
        public void UpdateRemoveLifeAI()
        {
            for (int i = lifePanelAI.Controls.Count - 1; i >= 0; i--)
            {
                if (lifePanelAI.Controls[i] is PictureBox pb && pb.Visible)
                {
                    pb.Visible = false;
                    break;
                }
            }
            ShakeControlAI();
        }

        private void UpdateUIOnPlay(bool play)
        {
            if (!play)
            {
                EnableShootButton(true);
                EnableReloadButton(true);
                EnableDefendButton(true);
                EnablePlayButton(false);
                if(Game.Instance.player.Shotgun()) EnableShotgunButton(true);

                UpdateLabetText("");
                UpdateLabetTextAI("");
                pictureBoxCurrentDraw.Image = null;
                pictureBoxCurrentDrawAI.Image = null;
            }
            else
            {
                EnableShootButton(false);
                EnableReloadButton(false);
                EnableDefendButton(false);
                EnableShotgunButton(false);
            }
        }
        private void EnablePlayButton(bool on)
        {
            if (on)
            {
                buttonPlayTurn.Enabled = true;
                buttonPlayTurn.ForeColor = Color.White;
                buttonPlayTurn.BackColor = Color.SaddleBrown;
                buttonPlayTurn.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                buttonPlayTurn.Enabled = false;
                buttonPlayTurn.BackColor = Color.FromArgb(100, Color.SaddleBrown);
                buttonPlayTurn.ForeColor = Color.LightGray;
                buttonPlayTurn.FlatAppearance.BorderColor = Color.Gray;
            }
        }

        private void EnableShootButton(bool on)
        {
            if (on)
            {
                buttonShoot.Enabled = true;
                buttonShoot.ForeColor = Color.White;
                buttonShoot.BackColor = Color.SaddleBrown;
                buttonShoot.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                buttonShoot.Enabled = false;
                buttonShoot.BackColor = Color.FromArgb(100, Color.SaddleBrown);
                buttonShoot.ForeColor = Color.LightGray;
                buttonShoot.FlatAppearance.BorderColor = Color.Gray;
            }
        }
        private void EnableReloadButton(bool on)
        {
            if (on)
            {
                buttonReload.Enabled = true;
                buttonReload.ForeColor = Color.White;
                buttonReload.BackColor = Color.SaddleBrown;
                buttonReload.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                buttonReload.Enabled = false;
                buttonReload.BackColor = Color.FromArgb(100, Color.SaddleBrown);
                buttonReload.ForeColor = Color.LightGray;
                buttonReload.FlatAppearance.BorderColor = Color.Gray;
            }
        }
        private void EnableDefendButton(bool on)
        {
            if (on)
            {
                buttonDefend.Enabled = true;
                buttonDefend.ForeColor = Color.White;
                buttonDefend.BackColor = Color.SaddleBrown;
                buttonDefend.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                buttonDefend.Enabled = false;
                buttonDefend.BackColor = Color.FromArgb(100, Color.SaddleBrown);
                buttonDefend.ForeColor = Color.LightGray;
                buttonDefend.FlatAppearance.BorderColor = Color.Gray;
            }
        }
        private void EnableShotgunButton(bool on)
        {
            if (on)
            {
                buttonShotgun.Enabled = true;
                buttonShotgun.ForeColor = Color.White;
                buttonShotgun.BackColor = Color.SaddleBrown;
                buttonShotgun.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                buttonShotgun.Enabled = false;
                buttonShotgun.BackColor = Color.FromArgb(100, Color.SaddleBrown);
                buttonShotgun.ForeColor = Color.LightGray;
                buttonShotgun.FlatAppearance.BorderColor = Color.Gray;
            }
        }

        public void UpdateInfoText(string text)
        {
            labelInfo.Text = text;
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            if (Game.Instance.player.SetAction(ActionType.Shotgun)) EnablePlayButton(true);
        }
        public async void ShakeControlAI(int distance = 10, int speed = 30, int duration = 600)
        {
            var original = pictureBoxAIIcon.Location;
            var rand = new Random();
            int elapsed = 0;

            while (elapsed < duration)
            {
                pictureBoxAIIcon.Location = new Point(
                    original.X + rand.Next(-distance, distance),
                    original.Y + rand.Next(-distance, distance)
                );

                await Task.Delay(speed);
                elapsed += speed;
            }
            pictureBoxAIIcon.Location = original;
        }
        public async void ShakeControl(int distance = 10, int speed = 35, int duration = 600)
        {
            var original = pictureBoxPlayerIcon.Location;
            var rand = new Random();
            int elapsed = 0;

            while (elapsed < duration)
            {
                pictureBoxPlayerIcon.Location = new Point(
                    original.X + rand.Next(-distance, distance),
                    original.Y + rand.Next(-distance, distance)
                );

                await Task.Delay(speed);
                elapsed += speed;
            }
            pictureBoxPlayerIcon.Location = original;
        }
    }
}
