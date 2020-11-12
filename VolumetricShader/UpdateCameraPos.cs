using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using VolumetricShader.Effects;

namespace VolumetricShader
{
    public class UpdateCameraPos : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        public Entity camera;


        public override void Start()
        {
            // Initialization of the script.
        }

        public override void Update()
        {
            //var materials = Entity.Get<ModelComponent>().Materials;
            var material = Entity.Get<ModelComponent>().Materials.First().Value;
            material.Passes.First().Parameters.Set(VolumetricSphereKeys.CameraPos, camera.Transform.Position);
        }
    }
}
