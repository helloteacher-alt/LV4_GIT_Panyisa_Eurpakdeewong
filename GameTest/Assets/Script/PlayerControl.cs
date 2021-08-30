using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int score;
    public Text scoreText;
    public Text congratsText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        congratsText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveH,0.0f,moveV);
        rb.AddForce(movement*speed);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("cube"));
        {
            other.gameObject.SetActive(false);
            score = score +1;
            SetScoreText();
        }
    }
    void SetScoreText()
    {
        scoreText.text = "Score:"+score.ToString();
        if(score >= 8){
            congratsText.text = "You Win!";
        }
    }
}
