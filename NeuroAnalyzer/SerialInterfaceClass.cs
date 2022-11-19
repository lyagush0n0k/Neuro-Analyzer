using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Windows;

namespace NeuroAnalyzer
{
    public static class SerialInterfaceClass
    {
        private static readonly SerialPort _port = new();
        private static readonly int[] _spectrumData = new int[32];
        private static readonly List<int> _graphData = new();
        public static int graphPoint;
        public static int pulsePerMinte;
        public static int pulseInstability;
        private static Thread _serialThread;
        private static CancellationTokenSource tokenSource = new();

        public static void Init()
        {
            for (var i = 0; i < 32; i++) _graphData.Add(0);
        }

        public static string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public static void SetPort(string port)
        {
            _port.PortName = port;
            _port.BaudRate = 115200;
        }

        public static bool IsOpen()
        {
            return _port.IsOpen;
        }

        public static void StartReading()
        {
            _port.Open();
            _serialThread = new(ReadData);
            _serialThread.Start();
        }

        public static void StopReading()
        {
            _port.Close();
        }

        public static int[] GetSpectrumData()
        {
            return _spectrumData;
        }

        public static List<int> GetGraphData()
        {
            return _graphData;
        }

        private static void ReadData()
        {
            while (_port.IsOpen)
                try
                {
                    if (_port.BytesToRead <= 0) continue;
                    while (_port.ReadByte() != 0xAC)
                    {
                    }

                    if (_port.ReadByte() != 0xAB) continue;
                    Thread.Sleep(10);

                    var l = _port.ReadByte();
                    var h = _port.ReadByte();
                    pulsePerMinte = _port.ReadByte();
                    pulseInstability = _port.ReadByte();
                    graphPoint = ((h << 8) | l) - 512;
                    _graphData.Add(graphPoint);
                    _graphData.Remove(0);
                    for (var i = 0; i < 32; i++)
                    {
                        l = _port.ReadByte();
                        h = _port.ReadByte();
                        _spectrumData[i] = (h << 8) | l;
                    }

                    _port.DiscardInBuffer();
                }
                catch (Exception)
                {
                    break;
                }
        }
    }
}