﻿namespace CSS.Win32Service
{
    public interface IWin32Service
    {
        string ServiceName { get; }

        void Start();

        void Stop();
    }
}