using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Stride.Core;
using Stride.Core.Diagnostics;
using Stride.Input;
using Stride.Engine;
using Quaternion = Stride.Core.Mathematics.Quaternion;

namespace MyDemoCar
{
    public class RotatePot : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        [DataMember(1, "Rotation Speed")]
        public float RotationSpeed = 0.6f;

        public override void Start()
        {
            Log.ActivateLog(LogMessageType.Info);
            // Initialization of the script.
            Log.Info("RotatePot: On Start()");
        }

        public override void Update()
        {
            // Do stuff every new frame
            //Log.Info("RotatePot: On Update()");

            // We can access Delta time through the static 'Game' object.
            var deltaTime = (float)Game.UpdateTime.Elapsed.TotalSeconds;
            Entity.Transform.Rotation *= Quaternion.RotationY(RotationSpeed * deltaTime);
        }
    }
}
