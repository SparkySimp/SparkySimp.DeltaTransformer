using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkySimp.DeltaTransformer
{
    public class PropertyTransformation : Transformation
    {

        public PropertyTransformation()
        {
            DeltaProperties = new Dictionary<string, double>();
            TransformationTick += (_sender, _e) =>
            {
                // TODO: Implement the delta application here. Delta represents changes in the control's properties intended for summing. Use bindings.
            };
        }

        /// <summary>
        /// Represents the changes in the properties' values.
        /// </summary>
        public Dictionary<string, double> DeltaProperties { get; set; }

        public override TimeSpan Time { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override TimeSpan Elapsed => throw new NotImplementedException();

        public override event EventHandler<TransformationEventArgs> TransformationComplete;
        public override event EventHandler<TransformationEventArgs> TransformationStart;
        public override event EventHandler<TransformationEventArgs> TransformationTick;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Resume()
        {
            throw new NotImplementedException();
        }

        public override void Start(Control control)
        {
            TransformationStart(this, new TransformationEventArgs { 
                Control = control,
                CurrentTime = TimeSpan.Zero
            });
        }

        public override void Suspend()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
