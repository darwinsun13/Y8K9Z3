using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Completed
{
    public class Enemy : MovingObject
    {
        public int playerDamage;
        public int money;
        public int hp = 1;
        public int kill = 0;
        public Text killText;
        public bool isAlive = true;
        private Animator animator;
        private Transform target;
        private bool skipMove;

        public Sprite dmgSprite;
        private SpriteRenderer spriteRenderer;

        void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        protected override void Start()
        {
            GameManager.instance.AddEnemyToList(this);

            money = Random.Range(1, 10);

            animator = GetComponent<Animator>();

            target = GameObject.FindGameObjectWithTag("Player").transform;

            kill = GameManager.instance.playerKillPoints;

            if (killText != null)
            {
                killText.text = "Kill: " + kill;
            }


            base.Start();
        }

        protected override void AttemptMove<T>(int xDir, int yDir)
        {
            if (skipMove)
            {
                skipMove = false;
                return;
            }

            base.AttemptMove<T>(xDir, yDir);

            skipMove = true;
        }


        public void MoveEnemy()
        {
            int xDir = 0;
            int yDir = 0;

            if (Mathf.Abs(target.position.x - transform.position.x) < float.Epsilon)
                yDir = target.position.y > transform.position.y ? 1 : -1;
            else
                xDir = target.position.x > transform.position.x ? 1 : -1;

            AttemptMove<Player>(xDir, yDir);
        }


        protected override void OnCantMove<T>(T component)
        {
            Player hitPlayer = component as Player;

            animator.SetTrigger("enemyAttack");
        }

        //ReceiveDamage is called whenever the enemy gets hit by an attack by the player
        public void ReceiveDamage(int dmg)
        {
            spriteRenderer.sprite = dmgSprite;
            //enemy loses hp

            hp -= dmg;

            Debug.Log("Enemy takes " + dmg + " damage.");//for debug purposes
            //if hp is less than 0, destroy the enemy.
            if (hp <= 0)
            {
                isAlive = false;

                this.gameObject.SetActive(false);

                killText.text = "Kill: " + kill;
            }

        }


    }
}
