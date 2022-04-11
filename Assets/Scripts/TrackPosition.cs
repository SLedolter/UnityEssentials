using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPosition : MonoBehaviour {
  public Vector3 positionChange;

  private int direction = 1;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    if(transform.position.y > 4) {
      direction = -1;
    }
    if(transform.position.y < 2) {
      direction = 1;
    }
    transform.position += positionChange * Time.deltaTime * direction;
  }
}
