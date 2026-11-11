Взаимодействие микросервисов через GraphQl.
Сделано на основе документации https://chillicream.com/docs/fusion/getting-started
UsersREST подключился только через адаптер, как то стремно, нормальных доков не нашел, сделала ИИ.

Запуск всех сервисов через .NET Aspire (Gateway запускается после зависимостей):
```
dotnet run --project ./AppHost
```

Aspire Dashboard покажет состояние сервисов и адрес Gateway: `http://localhost:5000/graphql`.

Генерация схемы для GraphQl проектов, например для Products
```
dotnet run --project ./Products -- schema export 
```

Сборка общей схемы
```
nitro fusion compose -f Products/schema.graphqls -f Reviews/schema.graphqls -f Shipping/schema.graphqls -f UsersREST/schema.graphqls -a Gateway/gateway.far
```
