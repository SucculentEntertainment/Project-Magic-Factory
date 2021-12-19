using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;

namespace Tests.Entity.Controller
{
    public class PlayerControllerTests /*: InputTestFixture*/
    {
        [UnityTest]
        public IEnumerator TestInput()
        {
            // Mouse mouse = InputSystem.AddDevice<Mouse>();
            // Keyboard keyboard = InputSystem.AddDevice<Keyboard>();

            // Camera cam = new();

            // GameObject go = new();
            // BaseEntity entity = go.AddComponent<BaseEntity>() as BaseEntity;
            // PlayerController controller = go.AddComponent<PlayerController>() as PlayerController;
            // PlayerInput input = go.AddComponent<PlayerInput>() as PlayerInput;

            // input.actions = InputActionAsset.FromJson((Resources.Load("Input/InputActions.inputactions") as TextAsset).text);
            // input.camera = cam;
            // input.defaultActionMap = "Player";

            // controller.mainCamera = cam;
            // entity.controller = controller;
            // entity.init();
            // Assert.That(controller.parent, Is.EqualTo(entity));

            // Press(keyboard.wKey);
            // yield return new WaitForSeconds(0.1f);
            // Assert.That(entity.state, Is.EqualTo("move"));
            // Assert.That(entity.movDir, Is.EqualTo(new Vector2(0, 1)));
            // Release(keyboard.wKey);

            // Press(keyboard.aKey);
            // yield return new WaitForSeconds(0.1f);
            // Assert.That(entity.state, Is.EqualTo("move"));
            // Assert.That(entity.movDir, Is.EqualTo(new Vector2(-1, 0)));
            // Release(keyboard.aKey);

            // Press(keyboard.sKey);
            // yield return new WaitForSeconds(0.1f);
            // Assert.That(entity.state, Is.EqualTo("move"));
            // Assert.That(entity.movDir, Is.EqualTo(new Vector2(0, -1)));
            // Release(keyboard.sKey);

            // Press(keyboard.dKey);
            // yield return new WaitForSeconds(0.1f);
            // Assert.That(entity.state, Is.EqualTo("move"));
            // Assert.That(entity.movDir, Is.EqualTo(new Vector2(1, 0)));
            // Release(keyboard.dKey);

            // Object.Destroy(go);
            yield return null;
        }
    }
}