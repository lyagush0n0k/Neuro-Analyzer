using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;

namespace NeuroAnalyzer
{
    public class SerialInterfaceClass
    {
        private static readonly SerialPort _port = new();
        private static readonly Thread _serialThread = new(ReadData);
        private static readonly int[] _spectrumData = new int[32];
        private static readonly List<int> _graphData = new();

        public static void Init()
        {
            for (var i = 0; i < 32; i++) _graphData.Append(0);
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

        public static void StartReading()
        {
            _port.Open();
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
            while (true)
                try
                {
                    if (_port.BytesToRead > 0)
                    {
                        while (_port.ReadByte() != 0xAC) ;

                        if (_port.ReadByte() == 0xAB)
                        {
                            Thread.Sleep(2);

                            var l = _port.ReadByte();
                            var h = _port.ReadByte();
                            _graphData.Add(((h << 8) | l) - 512);
                            _graphData.Remove(0);
                            for (var i = 0; i < 32; i++)
                            {
                                l = _port.ReadByte();
                                h = _port.ReadByte();
                                _spectrumData[i] = (h << 8) | l;
                            }

                            _port.DiscardInBuffer();
                        }
                    }
                }
                catch (Exception)
                {
                    break;
                }
        }
    }
}