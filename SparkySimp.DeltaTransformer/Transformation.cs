using System;
using System.Windows.Forms;

namespace SparkySimp.DeltaTransformer
{
    /// <summary>
    /// Represents event arguments for transforming object.
    /// </summary>
    public class TransformationEventArgs : EventArgs
    {
        /// <summary>
        /// The <see cref="Control"/> that was used in transfomation.
        /// </summary>
        public Control Control { get; set; }

        /// <summary>
        /// The current position of the transformation.
        /// </summary>
        public TimeSpan CurrentTime { get; set; }

    }
    /// <summary>
    /// Represents the base class for all transformations.
    /// </summary>
    public abstract class Transformation
    {
        /// <summary>
        /// Represents the amount of time required to transform a control.
        /// </summary>
        public abstract TimeSpan Time { get; set; }

        /// <summary>
        /// Fires when the transformation completes.
        /// </summary>
        public abstract event EventHandler<TransformationEventArgs> TransformationComplete;

        /// <summary>
        /// Fires when the transformation starts.
        /// </summary>
        public abstract event EventHandler<TransformationEventArgs> TransformationStart;

        /// <summary>
        /// Fires every time a transformation progresses.
        /// </summary>
        public abstract event EventHandler<TransformationEventArgs> TransformationTick;

        /// <summary>
        /// Starts the transformation.
        /// </summary>
        /// <param name="control">The <see cref="Control"/> to apply this transformation on.</param>
        public abstract void Start(Control control);

        /// <summary>
        /// Suspends the transformation temporarily.
        /// </summary>
        public abstract void Suspend();

        /// <summary>
        /// Resumes a suspended transformation.
        /// </summary>
        public abstract void Resume();

        /// <summary>
        /// Represents the time passed since the transforon has started.
        /// </summary>
        public abstract TimeSpan Elapsed { get; }
    }
}
