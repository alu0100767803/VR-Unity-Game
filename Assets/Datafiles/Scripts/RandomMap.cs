using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour {

    public GameObject[] trees;
    public GameObject[] grass;
    public GameObject[] tombs;
    public GameObject[] statues;
    public GameObject[] fence;
    public GameObject[] phanteons;
    public GameObject[] others;

    void Start() {
        for (int i = 0; i < Random.Range(400, 500); i++) {
            treesCount();
        }
        for (int l = 0; l < 200; l++)
        {
            tombsCount();
        }

        for (int j = 0; j < 1000; j++) {
            grassCount();
        }

        for (int k = 0; k < 50; k++) {
            statuesCount();
        }

        for (int m = 0; m < 50; m++) {
            phanteonsCount();
        }

        for (int n = 0; n < 50; n++) {
            othersCount();
        }
        fences();

    }

    void Update() {

    }

    void treesCount() {
        int treesIndex = Random.Range(0, trees.Length);
        GameObject rtrees = Instantiate(trees[treesIndex]);
        rtrees.transform.parent = transform;
        rtrees.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }

    void grassCount() {
        int grassIndex = Random.Range(0, grass.Length);
        GameObject rgrass = Instantiate(grass[grassIndex]);
        rgrass.transform.parent = transform;
        rgrass.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }

    void tombsCount() {
        int a = Random.Range(-95, 95);
        int b = Random.Range(-95, 95);
        for (int i = 0; i < 5; i++) {
            if (a > -95 && a < 95)
            {
                int tombIndex = Random.Range(0, tombs.Length);
                GameObject rtombs = Instantiate(tombs[tombIndex]);
                rtombs.transform.parent = transform;
                rtombs.transform.localPosition = new Vector3(a, 0.0f, b);
                a += 3;
            }
        }
    }

    void statuesCount() {
        int statueIndex = Random.Range(0, statues.Length);
        GameObject rstatues = Instantiate(statues[statueIndex]);
        rstatues.transform.parent = transform;
        rstatues.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }

    void othersCount() {
        int othersIndex = Random.Range(0, others.Length);
        GameObject rothers = Instantiate(others[othersIndex]);
        rothers.transform.parent = transform;
        rothers.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }

    void phanteonsCount() {
        int phanteonIndex = Random.Range(0, phanteons.Length);
        GameObject rphanteon = Instantiate(phanteons[phanteonIndex]);
        rphanteon.transform.parent = transform;
        rphanteon.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }

    void fences() {
        int a = -100;
        int b = -100;
        GameObject rfence;
        while(a >= -100 && a <= 100) {
                rfence = Instantiate(fence[0]);
                rfence.transform.parent = transform;
                rfence.transform.localPosition = new Vector3(a, 0.0f, b);

                rfence = Instantiate(fence[1]);
                rfence.transform.parent = transform;
                rfence.transform.localPosition = new Vector3(b, 0.0f, a);
                a += 5;
            
        }

        a = -100;
        b = 100;

        while (a >= -100 && a <= 100)
        {
                rfence = Instantiate(fence[0]);
                rfence.transform.parent = transform;
                rfence.transform.localPosition = new Vector3(a, 0.0f, b);

                rfence = Instantiate(fence[1]);
                rfence.transform.parent = transform;
                rfence.transform.localPosition = new Vector3(b, 0.0f, a);
                a += 5;
        }


    }
}
