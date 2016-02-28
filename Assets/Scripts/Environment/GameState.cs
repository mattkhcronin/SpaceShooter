using UnityEngine;
using System.Collections;

public static class GameState {

    public static IEnumerator OnDeath()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel(0);
    }
}
