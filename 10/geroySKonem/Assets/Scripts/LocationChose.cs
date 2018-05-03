using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationChose : MonoBehaviour
{
	static int hp = 100;
	static int dmg = 50;
	static int gold = 0;
	static int maxHp = 100;
	static int horse = 1;
	static int roguehp = 150;
	static int gianthp = 400;
	static int swordOrArmor;

	void RemoveListeners ()
	{
		button1.onClick.RemoveAllListeners ();
		button2.onClick.RemoveAllListeners ();
		button3.onClick.RemoveAllListeners ();
		button4.onClick.RemoveAllListeners ();
	}

	void ClearText ()
	{
		Text text1 = button1.GetComponentInChildren<Text> ();
		Text text2 = button2.GetComponentInChildren<Text> ();
		Text text3 = button3.GetComponentInChildren<Text> ();
		Text text4 = button4.GetComponentInChildren<Text> ();
		text1.text = "";
		text2.text = "";
		text3.text = "";
		text4.text = "";
		dialog.text = "";
	}

	void LocationChoise ()
	{
		ClearText ();
		Text text1 = button1.GetComponentInChildren<Text> ();
		Text text2 = button2.GetComponentInChildren<Text> ();
		Text text3 = button3.GetComponentInChildren<Text> ();
		Text text4 = button4.GetComponentInChildren<Text> ();
		text1.text = "Зелёные поля";
		text2.text = "Торговец";
		text3.text = "Лес";
		text4.text = "Деревня";
		enemyHpbar.text = "";
		enemydmgBar.text = "";
		showEnemyHpBar.text = "";
		showEnemydmgBar.text = "";
		RemoveListeners ();
		button1.onClick.AddListener (LocationFields);
		button2.onClick.AddListener (LocationTrader);
		button3.onClick.AddListener (LocationForest);
		button4.onClick.AddListener (LocationVilage);
	}

	void KeeperStories ()
	{
		dialog.text = "Спаси деревню от великана!";
	}

	void LocationFields ()
	{
		ClearText ();
		Text text1 = button1.GetComponentInChildren<Text> ();
		Text text2 = button2.GetComponentInChildren<Text> ();
		RemoveListeners ();
		button1.onClick.AddListener (LocationChoise);
		text1.text = "Выбрать Локацию";
		button2.onClick.AddListener (KeeperStories);
		text2.text = "Послушать хранителя";
	}

	void LocationTrader ()
	{
		ClearText ();
		Text text1 = button1.GetComponentInChildren<Text> ();
		Text text2 = button2.GetComponentInChildren<Text> ();
		Text text3 = button3.GetComponentInChildren<Text> ();
		Text text4 = button4.GetComponentInChildren<Text> ();
		RemoveListeners ();
		button1.onClick.AddListener (LocationChoise);
		text1.text = "Выбрать Локацию";
		button2.onClick.AddListener (TraderStories);
		text2.text = "Послушать Торговца";
		if (swordOrArmor == 0) {
			text3.text = "Купить Меч (1000)";	
		} else {
			text3.text = "Купить Броню (1000)";
		}

		button3.onClick.AddListener (DmgUp);
		if (horse == 1) {
			text4.text = "Продать лошадь";
			button4.onClick.AddListener (SellHorse);
		}
	}

	void DmgUp ()
	{
		if (gold>=1000) {
			gold = gold - 1000;
			goldBar.text = gold.ToString ();
			dmg = dmg + 50;
			dmgBar.text = dmg.ToString ();
		}


	}

	void LocationForest ()
	{
		ClearText ();
		Text text1 = button1.GetComponentInChildren<Text> ();
		Text text2 = button2.GetComponentInChildren<Text> ();
		RemoveListeners ();

		button1.onClick.AddListener (LocationChoise);
		text1.text = "Выбрать Локацию";
		text2.text = "атаковать бандитов";
		if (roguehp > 0) {
			ShowEnemy (roguehp, 150, 70);
			text2.text = "атаковать бандитов";
			button2.onClick.AddListener (AttackRogue);
		}

	}

	void AttackRogue(){
		AttackEnemy (roguehp, 150, 70, "rogue");
	}
	void LocationVilage(){
		ClearText ();
		Text text1 = button1.GetComponentInChildren<Text> ();
		Text text2 = button2.GetComponentInChildren<Text> ();
		RemoveListeners ();

		button1.onClick.AddListener (LocationChoise);
		text1.text = "Выбрать Локацию";

		if (gianthp > 0) {
			text2.text = "атаковать гиганта";
			ShowEnemy (gianthp, 400, 100);
			button2.onClick.AddListener (AttackGiant);
		}

	}
	void AttackGiant(){
		AttackEnemy (gianthp, 400, 100, "giant");
	}
	void AttackEnemy (int enemyHp, int enemyMaxHp, int enemyMaxDmg,string target)
	{
		hp = hp - ReduceDmg (enemyMaxDmg, enemyHp, enemyMaxHp);

		hpBar.text = (hp.ToString () + "/" + maxHp.ToString ());
		if (hp<=0) {
			
			RemoveListeners ();
			ClearText ();
			dialog.text = "вы проиграли";
		}
		enemyHp = enemyHp - dmg;
		ShowEnemy (enemyHp, enemyMaxHp, enemyMaxDmg);
		if (target=="rogue") {
			roguehp = roguehp - dmg;
			if (roguehp<=0) {
				dialog.text = "Вы победили бандита";
				maxHp = 400;
				hp = maxHp;
				hpBar.text = (hp.ToString () + "/" + maxHp.ToString ());
				Text text2 = button2.GetComponentInChildren<Text> ();
				text2.text = "";
				button2.onClick.RemoveAllListeners();
			}
		} else {
			gianthp = gianthp - dmg;
			if (gianthp<=0) {
				
				hp = maxHp;
				hpBar.text = (hp.ToString () + "/" + maxHp.ToString ());
				RemoveListeners ();
				ClearText ();
				dialog.text = "Вы победили великана";
			}
		}


		
	}

	void ShowEnemy (int enemyHp, int enemyMaxHp, int enemyMaxDmg)
	{
		enemydmgBar.text = (ReduceDmg (enemyMaxDmg, enemyHp, enemyMaxHp)).ToString();
		showEnemyHpBar.text = "Здоровье Врага:";
		enemyHpbar.text = enemyHp.ToString ();
		showEnemydmgBar.text = "Урон Врага:";
	}

	int ReduceDmg (int maxDmg, int hp, int maxHp)
	{
		return (int)(maxDmg * ((double)hp / maxHp));
	}

	void SellHorse ()
	{
		horse = 0;
		gold = gold + 1000;
		goldBar.text = gold.ToString ();
		LocationTrader ();
	}

	void TraderStories ()
	{
		string[] traderStories = new string[2];
		traderStories [0] = "Когда-то и меня вела дорога приключений… А потом мне прострелили колено";
		traderStories [1] = "Моя семья владеет этой лавкой уже несколько поколений";
		dialog.text = traderStories [Random.Range (0, 2)];
	}

	public Text goldBar;
	public Text hpBar;
	public Text dmgBar;
	public Text dialog;
	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Text enemyHpbar;
	public Text enemydmgBar;
	public Text showEnemyHpBar;
	public Text showEnemydmgBar;
	// Use this for initialization
	void Start ()
	{
		dmgBar.text = dmg.ToString ();
		hpBar.text = (hp.ToString () + "/" + maxHp.ToString ());
		LocationFields ();
		swordOrArmor = Random.Range (0, 2);

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
