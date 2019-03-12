import java.io.*;
import java.net.*;

public class TestServer {

	public static final int port = 1234;
	
	public static void main(String[] args) throws IOException {
		ServerSocket server = new ServerSocket(port);
		System.out.println("Awaiting client..");
		Socket client = server.accept();
		System.out.println("CONNECTED");
		OutputStream out = client.getOutputStream();
		DataOutputStream dOut = new DataOutputStream(out);
		dOut.writeBytes("Hello world");
		dOut.flush();
		server.close();
	}
}
