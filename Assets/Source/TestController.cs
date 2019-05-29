using UnityEngine;
using Keiwando.UI;

public class TestController: MonoBehaviour {

    private SlidingContainer menu;

    [SerializeField] private float slideDuration = 0.6f;

    void Start() {
        this.menu = FindObjectOfType<SlidingContainer>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Slide();
        }
    }

    private void Slide() {
        var currentProgress = menu.AnimationProgress;
        if (menu.LastSlideDirection == SlidingContainer.Direction.Up) {
            menu.Slide(SlidingContainer.Direction.Down, slideDuration, 1f - currentProgress);
        } else {
            menu.Slide(SlidingContainer.Direction.Up, slideDuration, 1f - currentProgress);
        }
    }
}