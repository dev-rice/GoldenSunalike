using UnityEngine;
using System.Collections;

public class EnemyMouse : MonoBehaviour {

    SpriteRenderer sprite_renderer;
    public GameObject menu_controller_object;
    MenuController menu_controller;

    // Use this for initialization
	void Start () {
        sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
        menu_controller = menu_controller_object.GetComponent<MenuController>();
	}

	// Update is called once per frame
	void Update () {
        if (!menu_controller.attack_button_pressed && !menu_controller.magic_button_pressed) {
            sprite_renderer.color = new Color(1.0F, 1.0F, 1.0F);
        }
	}

    void OnMouseEnter() {
        if (menu_controller.attack_button_pressed) {
            sprite_renderer.color = new Color(1.0F, 0.0F, 0.0F);
        } else if (menu_controller.magic_button_pressed) {
            sprite_renderer.color = new Color(0.0F, 0.0F, 1.0F);
        }
    }

    void OnMouseExit() {
        sprite_renderer.color = new Color(1.0F, 1.0F, 1.0F);
    }
}
