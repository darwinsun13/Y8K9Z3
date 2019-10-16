using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Completed
{
	public class Player : MovingObject
	{
		public float restartLevelDelay = 1f;		
		public int pointsPerFood = 10;				
		public int pointsPerSoda = 20;				
		public int wallDamage = 1;					
		public int pointsPerCoin = 10;				
		public int pointsPerPotion = 20;								
        public int attackDamage = 1;                
		public Text foodText;
        public Text currency;
        public int direction = 0;
        public int str = 1;
        public int con = 1;
        public int dex = 1;

        public bool isPickedUp = true;
        private Animator animator;
		private int coin;                  
        private int money = 0;
#if UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE
        private Vector2 touchOrigin = -Vector2.one;	//Used to store location of screen touch origin for mobile controls.
#endif
		
		
		protected override void Start ()
		{
			animator = GetComponent<Animator>();

			coin = GameManager.instance.playerFoodPoints;

			foodText.text = "Coin: " + coin;

			base.Start ();
		}
		
		
		private void OnDisable ()
		{
			GameManager.instance.playerFoodPoints = coin;
		}
		
		
		private void Update ()
		{
			if(!GameManager.instance.playersTurn) return;
			
			int horizontal = 0;  	
			int vertical = 0;		
			
			//Check if we are running either in the Unity editor or in a standalone build.
#if UNITY_STANDALONE || UNITY_WEBPLAYER
			
			horizontal = (int) (Input.GetAxisRaw ("Horizontal"));
			
			vertical = (int) (Input.GetAxisRaw ("Vertical"));
			

			if(horizontal != 0)
			{
				vertical = 0;
			}

#endif
			if(horizontal != 0 || vertical != 0)
			{
				AttemptMove<Enemy> (horizontal, vertical);
			}
		}
		

		protected override void AttemptMove <T> (int xDir, int yDir)
		{
            

			foodText.text = "Coin: " + coin;

			base.AttemptMove <T> (xDir, yDir);

			RaycastHit2D hit;

			GameManager.instance.playersTurn = false;
		}
		

		protected override void OnCantMove <T> (T component)
		{
            Enemy enemy = component as Enemy;
            enemy.ReceiveDamage (100);
		}

        //AttemptAttack is called when the player presses the button assigned for attacking.
        //It checks the space immediately in front of the player, based on the direction they are facing.
        //Returns true if the attack hits something, false if there is nothing to hit.
        //Currently has no functionality.
        //TODO: add functionality.
        protected bool AttemptAttack()
        {
            bool hit = true;
            
            return hit;
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Staircase")
            {
                Invoke("Restart", restartLevelDelay);
                enabled = false;
            }

            else if (other.tag == "Potion")
            {
                coin += pointsPerPotion;
                foodText.text = "+" + pointsPerPotion + " Health: " + coin;
                isPickedUp = false;
                other.gameObject.SetActive(false);
            }

            else if (other.tag == "Coin")
            {
                money += pointsPerCoin;
                currency.text = "$: " + money;
                other.gameObject.SetActive(false);
            }
        }


        private void Restart ()
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
		}
		
		
        /*private void CheckIfGameOver() {

            if (food <= 0)
            GameManager.instance.GameOver();
        }*/
           
	}
}

