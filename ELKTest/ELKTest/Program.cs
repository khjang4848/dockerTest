// See https://aka.ms/new-console-template for more information

using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using Serilog;
using Serilog.Core;

Console.WriteLine("임수민 만세");


// Elasticsearch 서버 URL
//var settings = new ElasticsearchClientSettings(new Uri("https://localhost:9200"))
//    .CertificateFingerprint("90:0D:B6:07:61:46:07:8D:92:AC:A2:A0:8A:CA:98:9D:08:E0:EB:10:BC:84:62:6F:D6:15:23:B5:87:08:FB:96")
//    .Authentication(new BasicAuthentication("elastic", "word1234")) // 인증 정보 (필요 시)
//    .DefaultIndex("default-index"); // 기본 인덱스 설정
//// 클라이언트 생성
//var client = new ElasticsearchClient(settings);
//// 연결 테스트
//var pingResponse = client.Ping();
//if (pingResponse.IsValidResponse)
//{
//    Console.WriteLine("Elasticsearch 연결 성공!");
//}
//else
//{
//    Console.WriteLine($"Elasticsearch 연결 실패: {pingResponse.DebugInformation}");
//}

//// 예제: 문서 색인
//var document = new
//{
//    Id = 1,
//    Name = "Sample Document",
//    CreatedAt = DateTime.UtcNow
//};
//var indexResponse = client.Index(document);

//if (indexResponse.IsValidResponse)
//{
//    Console.WriteLine("문서 색인 성공!");
//}
//else
//{
//    Console.WriteLine($"문서 색인 실패: {indexResponse.DebugInformation}");
//}

Log.Logger = new LoggerConfiguration().WriteTo
    .Console().WriteTo.Http("http://localhost:8080") // Logstash로 HTTP 로그 전송
    .CreateLogger();
