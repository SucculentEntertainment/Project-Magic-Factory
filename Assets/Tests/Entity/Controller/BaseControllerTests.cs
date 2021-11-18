using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.Entity.Controller
{
    public class BaseControllerTests
    {
        [Test]
        public void TestEntityLink()
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
    }
}