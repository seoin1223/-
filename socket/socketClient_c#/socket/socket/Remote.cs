using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace socket
{
    class Remote
    {
        public string ServerIpAddress { set; get; }
        public string MainPort { set; get; }
        public readonly char STX = (char)0x02;
        public readonly char ETX = (char)0x03;


        public event Action<string> OnMessage;

        public Remote(string ServerIpAddress, string MainPort)
        {
            this.ServerIpAddress = ServerIpAddress;
            this.MainPort = MainPort;
        }

        public bool ValueCheck()
        {
            var properties = new[] { ServerIpAddress, MainPort };
            return properties.All( prop=> !string.IsNullOrEmpty(prop));
        }
        
        public void Connect(Dto dto)
        {
            if (!ValueCheck())
            {
                OnMessage?.Invoke("소켓 통신 초기화가 되지 않았습니다");
                return;
            }

            try
            {
                OnMessage?.Invoke("서버 연결을 시도합니다 ... ");
                using (TcpClient client = new TcpClient(ServerIpAddress, int.Parse(MainPort))) // 생성과 동시에 연결 시도
                {
                    OnMessage?.Invoke("서버 연결에 성공하였습니다 ... ");

                    NetworkStream send = client.GetStream(); // 서버에 전송할 Stream
                    string flag = dto.WEIGHT_FLAG; // WEIGHT_FLAG가 1이면 1차 중량,  2면 2차 중량
                    string interface_id = dto.INTERFACE_ID;


                    string s1 = dto.CAR_NUMBER.PadRight(12);


                    byte[] sendStream = Encoding.ASCII.GetBytes(STX + dto.CAR_NUMBER.PadRight(12) + dto.INTERFACE_ID.PadRight(13)+"0"+flag+ETX);
                    OnMessage?.Invoke($"sendStream{sendStream}"); // sendStream 확인
                    OnMessage?.Invoke($"입차 Test1");

                    send.Write(sendStream,0,sendStream.Length);
                    OnMessage?.Invoke("입차 Test2");

                    send.Flush();


                    byte[] inStream = new byte[1024];
                    client.ReceiveBufferSize = 1024;
                    OnMessage?.Invoke("입차 Test3");


                    int numberOfByTestRead = 0;
                    OnMessage?.Invoke("입차 Test4");

                    String returndata = System.Text.Encoding.ASCII.GetString(inStream, 0, numberOfByTestRead);
                    OnMessage?.Invoke($"입차 서버와 통신정보 : {returndata}");

                    client.Close();
                    OnMessage?.Invoke("입차 서비스를 종료합니다");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외 발생: " + ex.Message);
            }
        }
    }


}
