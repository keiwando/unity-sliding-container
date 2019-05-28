using UnityEngine;
using Keiwando.UI;

public class TestController: MonoBehaviour {

    private SlidingMenu menu;

    [SerializeField] private float slideDuration = 0.6f;

    void Start() {
        this.menu = FindObjectOfType<SlidingMenu>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Slide();
        }
    }

    private void Slide() {
        var currentProgress = menu.AnimationProgress;
        if (menu.LastSlideDirection == SlidingMenu.Direction.Up) {
            menu.Slide(SlidingMenu.Direction.Down, slideDuration, 1f - currentProgress);
        } else {
            menu.Slide(SlidingMenu.Direction.Up, slideDuration, 1f - currentProgress);
        }
    }
}