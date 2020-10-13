using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public BulletController bullet;
    public BulletController fatBullet;
    public BulletController pulsingBullet;


    public BulletController createBullet(string name)
    {
        BulletController tempBullet;


        switch (name)
        {
            case "Bullet":
                tempBullet = Instantiate(this.bullet,);
                break;
            case "Fat Bullet":
                Debug.Log(" + 20");
                break;
            case "Pulsing Bullet":
                Debug.Log(" + 30");
                break;
        }

        return tempBullet;
    }
}
