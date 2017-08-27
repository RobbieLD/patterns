using System;

namespace Patterns.Singleton
{
    /// <summary>
    /// This class is seald so that noone else can extend it and change it's behavior.
    /// This class also impliments IDisposable beause it's good practice for this kind 
    /// of class, not because it's part of the Singleton pattern. 
    /// </summary>
    public sealed class BikeWorldRecordRegister : IDisposable
    {
        private bool _disposed;
        /// <summary>
        /// This private instance variable is declared as volatile 
        /// to ensure that the instantiation is completed before
        /// any access to it is allowed. This helps ensure thread saftly
        /// by making sure another instance of this class isn't created
        /// while this one is being created.
        /// </summary>
        private static volatile BikeWorldRecordRegister _instance;

        /// <summary>
        /// The syncLock object is called this by convention. It simply 
        /// acts as a 
        /// </summary>
        private static readonly object _syncLock = new object();

        // Some records we wan't to track

        public int FastestTopSpeed { get; set; }

        public int FastestAverageSpeedOver100Km { get; set; }
        

        /// <summary>
        /// This private constructor ensures that the only thing 
        /// which can create this object is it's self, thus ensureing it
        /// remains a singleton
        /// </summary>
        private BikeWorldRecordRegister()
        {
        }

        public static BikeWorldRecordRegister Instance
        {
            get
            {
                if (_instance != null)
                {
                    // If the class has been created then simply return it.
                    return _instance;
                }
                else
                {
                    // We need to create it for the first and only time.
                    // The lock here prevents this object from being created more than once 
                    // because the _syncLock object is instantiated when this class is created. 
                    // Thus as long as the obejct is locked for access while we new up the first 
                    // and only instance of it, there will never be another one. 
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            // Prior to C# version 6 we would need another lock here but the volatile keyword fixes that now.
                            _instance = new BikeWorldRecordRegister();
                        }
                    }

                    return _instance;
                }
            }
        }

        public void PrinRecords()
        {
            Console.WriteLine($"Fastest Average Speed: {FastestAverageSpeedOver100Km}");
            Console.WriteLine($"Fastest Top Speed: {FastestTopSpeed}");
        }

        public void Dispose()
        {
            // Dispose of this class. The true argument here 
            // means this call called from users code. Fase would mean
            // it was called by the garbage collection.
            Dispose(true);

            // Since we've called dispose already we can take this 
            // object off the garbage collection heap.
            GC.SuppressFinalize(this);

        }

        private void Dispose(bool disposing)
        {
            // check to see if dispose has already been called
            if (_disposed) return;

            // Manually dispose all expensive resources.
            if(disposing)
            {
                _instance = null;
            }
        }
    }
}
