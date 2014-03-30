// Program: QuartersGame
// Author: Gary Sibbitts
// Description: Program to demonstrate modularity

// Using stuff
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuartersGame
{
    public partial class frmQuarters : Form
    {
        const int MATCH = 0;
        const int MISMATCH = 1;
        const int HEADS = 0;
        const int TAILS = 1;
        const int PLAYER_WINS = 0;
        const int COMPUTER_WINS = 1;

#region "FormRandom"
        private Random flipCoin;
        public frmQuarters()
        {
            InitializeComponent();
            flipCoin = new Random(System.DateTime.Now.Millisecond);
        }
#endregion

        private void PlayGame(int playerChoice)
        {
            Random flipCoin = new Random(System.DateTime.Now.Millisecond);
            int computerCoin = flipCoin.Next(2);
            int playerCoin = flipCoin.Next(2);
            pbComputerHeads.Visible = (computerCoin == HEADS);
            pbComputerTails.Visible = (computerCoin == TAILS);
            pbPlayerHeads.Visible = (playerCoin == HEADS);
            pbPlayerTails.Visible = (playerCoin == TAILS);

        }
        private void btnMatch_Click(object sender, EventArgs e)
        {
            // Player pick match
            PlayGame(MATCH);
        }

        private void btnMismatch_Click(object sender, EventArgs e)
        {
            // Player picks mismatch
            PlayGame(MISMATCH);
        }


 #region "subroutines"

        private void PlayGame2(int playerChoice)
        {
            int computerCoin = FlipCoin(ref pbComputerHeads, ref pbComputerTails);  // flipCoin.Next(2);
            int playerCoin = FlipCoin(ref pbPlayerHeads, ref pbPlayerTails);  //  flipCoin.Next(2);
        }

        private int FlipCoin(ref PictureBox pbHeads, ref PictureBox pbTails)
        {
            int coin = flipCoin.Next(2);
            pbHeads.Visible = (coin == HEADS);
            pbTails.Visible = (coin == TAILS);
            return coin;
        }
 #endregion

    }

}
