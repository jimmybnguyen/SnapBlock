using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenBook : MonoBehaviour {

    [SerializeField]
    private BookControl bookCrontrol;
    [SerializeField]
    private bool bookOpen = false;
    [SerializeField]
    private GameObject leafEmitter;
    [SerializeField]
    private GameObject mainButterfly;
    [SerializeField]
    private GameObject group;
    [SerializeField]
    private GameObject group2;
    [SerializeField]



    void Start()
    {
        bookCrontrol = this.GetComponent<BookControl>();
        group.gameObject.SetActive(false);
        group2.gameObject.SetActive(false);
        mainButterfly.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.L))
        {
            TurnBookCover();
        }
        if (bookOpen)
        {
            mainButterfly.gameObject.SetActive(true);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("colliding");
            TurnBookCover();
    }

    public void TurnBookCover()
    {
        bookCrontrol.Open_Book();
        bookOpen = true;
        group.gameObject.SetActive(true);
        group2.gameObject.SetActive(true);
       

    }
}
