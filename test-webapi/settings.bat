dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=192.168.1.7;Database=TestWebApiDb;User Id=sa;Password=Constance1;TrustServerCertificate=True;"
dotnet user-secrets set "EmailSettings:SmtpServer" "mail.ukdns.biz"
dotnet user-secrets set "EmailSettings:SmtpPort" 587
dotnet user-secrets set "EmailSettings:EnableSsl" true
dotnet user-secrets set "EmailSettings:FromEmail" "malcolm@malcsdomain.co.uk"
dotnet user-secrets set "EmailSettings:FromName" "SKY Technical Services"
dotnet user-secrets set "EmailSettings:SmtpUsername" "malcolm@malcsdomain.co.uk"
dotnet user-secrets set "EmailSettings:SmtpPassword" "1StepBeyond!"