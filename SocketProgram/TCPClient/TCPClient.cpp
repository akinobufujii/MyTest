#include <stdio.h>
#define _WINSOCK_DEPRECATED_NO_WARNINGS
#include <winsock2.h>
#include <assert.h>
#pragma comment (lib, "Ws2_32.lib")

int main()
{
	WSADATA wsaData;
	struct sockaddr_in server;
	SOCKET sock;
	char buf[32];

	// winsock2�̏�����
	if(WSAStartup(MAKEWORD(2, 0), &wsaData))
	{
		assert(false);
		return 1;
	}

	// �\�P�b�g�̍쐬
	sock = socket(AF_INET, SOCK_STREAM, 0);

	// �ڑ���w��p�\���̂̏���
	server.sin_family = AF_INET;
	server.sin_port = htons(12345);
	server.sin_addr.S_un.S_addr = inet_addr("127.0.0.1");

	// �T�[�o�ɐڑ�
	connect(sock, (struct sockaddr *)&server, sizeof(server));

	// �T�[�o����f�[�^����M
	memset(buf, 0, sizeof(buf));
	int n = recv(sock, buf, sizeof(buf), 0);

	printf("%d, %s\n", n, buf);

	// winsock2�̏I������
	WSACleanup();

	return 0;
}
