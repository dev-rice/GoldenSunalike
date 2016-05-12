using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

    public bool attack_button_pressed = false;
    public bool defend_button_pressed = false;
    public bool magic_button_pressed = false;

    public Texture2D default_cursor_texture;
    public Texture2D attack_cursor_Texture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(default_cursor_texture, Vector2.zero, cursorMode);
	}

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("escape")) {
            clearSelection();
            Cursor.SetCursor(default_cursor_texture, Vector2.zero, cursorMode);
        }

        if (attack_button_pressed) {
            Cursor.SetCursor(attack_cursor_Texture, hotSpot, cursorMode);
        }
	}

    void attackButtonPressed() {
        attack_button_pressed = true;
    }

    void defendButtonPressed() {
        defend_button_pressed = true;
    }

    void magicButtonPressed() {
        magic_button_pressed = true;
    }

    void clearSelection() {
        attack_button_pressed = false;
        defend_button_pressed = false;
        magic_button_pressed = false;
    }
}
