using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;

namespace Tests
{
    public class EntitySystemTests : InputTestFixture
    {
        [Test]
        public void TestEntityControllerLink()
        {
            GameObject go = new();
            BaseEntity entity = go.AddComponent(typeof(BaseEntity)) as BaseEntity;
            BaseController controller = go.AddComponent(typeof(BaseController)) as BaseController;

            entity.controller = controller;
            entity.init();
            Assert.That(controller.parent, Is.EqualTo(entity));

            controller.parent.setData(new Vector2(1, 2), new Vector2(3, 4), "test", "returnTest");

            Assert.That(entity.movDir, Is.EqualTo(new Vector2(1, 2)));
            Assert.That(entity.aimDir, Is.EqualTo(new Vector2(3, 4)));
            Assert.That(entity.state, Is.EqualTo("test"));
            Assert.That(entity.returnState, Is.EqualTo("returnTest"));

            Object.Destroy(go);
        }

        [UnityTest]
        public IEnumerator TestPlayerControllerInput()
        {
            Mouse mouse = InputSystem.AddDevice<Mouse>();
            Keyboard keyboard = InputSystem.AddDevice<Keyboard>();

            Camera cam = new();

            GameObject go = new();
            BaseEntity entity = go.AddComponent<BaseEntity>() as BaseEntity;
            PlayerController controller = go.AddComponent<PlayerController>() as PlayerController;
            PlayerInput input = go.AddComponent<PlayerInput>() as PlayerInput;

            input.actions = Resources.Load<InputActionAsset>("Settings/Input/InputActions.inputactions");
            input.camera = cam;

            controller.mainCamera = cam;
            entity.controller = controller;
            entity.init();
            Assert.That(controller.parent, Is.EqualTo(entity));

            Press(keyboard.wKey);
            yield return new WaitForSeconds(0.1f);
            Assert.That(entity.state, Is.EqualTo("move"));
            Assert.That(entity.movDir, Is.EqualTo(new Vector2(0, 1)));
            Release(keyboard.wKey);

            Press(keyboard.aKey);
            yield return new WaitForSeconds(0.1f);
            Assert.That(entity.state, Is.EqualTo("move"));
            Assert.That(entity.movDir, Is.EqualTo(new Vector2(-1, 0)));
            Release(keyboard.aKey);

            Press(keyboard.sKey);
            yield return new WaitForSeconds(0.1f);
            Assert.That(entity.state, Is.EqualTo("move"));
            Assert.That(entity.movDir, Is.EqualTo(new Vector2(0, -1)));
            Release(keyboard.sKey);

            Press(keyboard.dKey);
            yield return new WaitForSeconds(0.1f);
            Assert.That(entity.state, Is.EqualTo("move"));
            Assert.That(entity.movDir, Is.EqualTo(new Vector2(1, 0)));
            Release(keyboard.dKey);

            Object.Destroy(go);
            yield return null;
        }
    }
}