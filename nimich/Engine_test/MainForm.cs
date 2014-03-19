using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using nimEngine;

namespace Engine_test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Player player1;
		Player player2;
		Game gme;
		bool player1Turn;
		bool turn;
		bool gameInPlay = false;
		
		public MainForm()
		{
			InitializeComponent();
			Form.CheckForIllegalCrossThreadCalls = false;
		}
		
		void BtnStartClick(object sender, EventArgs e)
		{
			player1 = new Human(txtPlayer1Name.Text);
			player1.playerStartedTurn += 
			delegate
			{
				player1Turn = true;
				turn = true;
			};
			
			player2 = new Human(txtPlayer2Name.Text);
			player2.playerStartedTurn += 
			delegate
			{
				player1Turn = false;
				turn = true;
			};
			
			gme = new Game(player1,player2,13);
			gme.gameOver += gameOverTriggered;
			gme.start();
			gameInPlay = true;
			
			new Thread(new ThreadStart(refreshSticks)).Start();
		}
		
		void gameOverTriggered(GameOverEventArgs e)
		{
			gameInPlay = false;
			MessageBox.Show(e.winner.ident + " gewinnt");
		}
		
		void BtnTakeClick(object sender, EventArgs e)
		{
			if(player1Turn)
			{
				((Human)player1).AmountNextTurn = Convert.ToInt32(txtTakeSticks.Text);
				((Human)player1).ReadyForTurn = true;
			}
			else
			{
				((Human)player2).AmountNextTurn = Convert.ToInt32(txtTakeSticks.Text);
				((Human)player2).ReadyForTurn = true;
			}
		}
		
		void refreshSticks()
		{
			while(gameInPlay)
			{
				int stickccount = gme.StickCount;
				lblSticks.Text = "";
				
				for(int i = 0; i < stickccount; i++)
				{
					lblSticks.Text += " | ";
				}
				
				Thread.Sleep(200);
			}
		}
	}
}
