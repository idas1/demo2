# demo2
yc có docker desktop

cd demo2
docker-compose up -d

cd Ecommerce.API
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run

cd frontend
npm install
npm run dev
