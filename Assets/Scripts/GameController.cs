using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public List<Image> imazes;
    public List<Sprite> sprites;

    int imazecount;
    int spritenum;
    int imazenum;

    int white;
    int black;
    // Start is called before the first frame update

    public static GameController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Start()
    {
     
      for(int i=0;i<imazes.Count;i++)
        {
            spritenum= Random.Range(0,sprites.Count);
            if(spritenum==0)
            {
                white += 1;
            }
            else
            {
                black+= 1;
            }
            imazes[i].sprite = sprites[spritenum];
        }
        StartCoroutine(Waitpannu());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Waitpannu() 
    {
        yield return new WaitForSeconds(3f);

    }
}
