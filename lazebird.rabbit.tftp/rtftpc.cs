﻿using System.IO;
            while (true)
                int len = tftpSocket.ReceiveFrom(rcvBuffer, ref dataEP);
                serverEP.Port = ((IPEndPoint)dataEP).Port;
                if (((Opcodes)rcvBuffer[1]) == Opcodes.Error)
                if (len < 516)
                {
                    break;
                }
            }
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse(srvip), srvport);
            byte[] sndBuffer = CreateReqPacket(Opcodes.Write, remoteFile, tftpMode);
            int blkno = 0;
            while (true)