using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace MDIForm_1 {
  class DataCollector {
    private readonly Action<List<byte>> _processMeasurement;
    private string _port;
    public bool portState;

    private int _baud;
    public int bytesRead;
    private SerialPort _serialPort;

    //=============================================================================================
    public string port {
      get {
        return _port;
      }

      set {
        _port = value;
      }
    }

    //=============================================================================================
    public int baud {
      get {
        return _baud;
      }

      set {
        _baud = value;
      }
    }

    private const int SizeOfMeasurement = 4;
    List<byte> Data = new List<byte>();


    //=============================================================================================
    public DataCollector(string nPort, int nBaud, Action<List<byte>> processMeasurement) {
      _processMeasurement = processMeasurement;
      _port = nPort;
      _baud = nBaud;

      portState = false;
      _serialPort = new SerialPort(_port);
      _serialPort.DataReceived += SerialPortDataReceived;
      bytesRead = 0;
    }

    //=============================================================================================
    public void openPort(string nPort, int nBaud) {
      _port = nPort;
      _baud = nBaud;
      openPort();
    }

    //=============================================================================================
    public void openPort() {
      _serialPort.BaudRate = _baud;
      _serialPort.PortName = _port;
      try {
        _serialPort.Open();
        if( _serialPort.IsOpen ) {
          portState = true;
        }
        else
          portState = false;
      }
      catch {
        MessageBox.Show("Unable to open Port", "COM error", MessageBoxButtons.OK);
        portState = false;
      }
    }

    //=============================================================================================
    public void closePort() {
      if( _serialPort.IsOpen ) {
        _serialPort.Close();
        portState = false;
      }
    }

    //=============================================================================================
    private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e) {

      if(_serialPort.IsOpen) {
        while( _serialPort.BytesToRead > 0) {
          var count = _serialPort.BytesToRead;
          var bytes = new byte[count];
          Console.WriteLine("Byte count:" + count.ToString());
          _serialPort.Read(bytes, 0, count);
          AddBytes(bytes);
        }
      }
    }

    //=============================================================================================
    private void AddBytes(byte[] bytes) {
      Data.AddRange(bytes);

      while( Data.Count > SizeOfMeasurement ) {
        var measurementData = Data.GetRange(0, SizeOfMeasurement);
        Data.RemoveRange(0, SizeOfMeasurement);
        if( _processMeasurement != null )
          _processMeasurement(measurementData);
      }

    }
  }
}
