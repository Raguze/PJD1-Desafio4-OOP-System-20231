using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public string PlayerName;
    public int Hp;
    public int Gold;
    public float Speed;

    [SerializeField]
    private string PlayerClassName = "Player Class";

    static public string Info = "Player Info";

    public Player()
    {
        PlayerName = "A player name";
        Hp = 50;
        Gold = 0;
        Speed = 2f;
    }

    public Player(int Hp)
    {
        PlayerName = "A player name";
        this.Hp = Hp;
    }

    public Player(string PlayerName, int Hp, int Gold, float Speed)
    {
        this.PlayerName = PlayerName;
        this.Hp = Hp;
        this.Gold = Gold;
        this.Speed = Speed;
    }

    public Player(string PlayerName)
    {
        this.PlayerName = PlayerName;
    }

    public void DebugInfo()
    {
        Debug.Log($"Player Class :: PlayerName:{PlayerName} Hp:{Hp} Gold:{Gold} Speed:{Speed} PlayerClassName:{PlayerClassName} Info:{Info}");
    }

    void Run()
    {
        
    }

    void Jump()
    {

    }
}
