Взаимодействие микросервисов через GraphQl.
Сделано на основе документации https://chillicream.com/docs/fusion/getting-started
UsersREST подключился только через адаптер, как то стремно, нормальных доков не нашел, сделала ИИ.

Надо запустить все сервисы, Gateway последним.

Генерация схемы для GraphQl проектов, например для Products
```
dotnet run --project ./Products -- schema export 
```

Сборка общей схемы
```
nitro fusion compose -f Products/schema.graphqls -f Reviews/schema.graphqls -f Shipping/schema.graphqls -f UsersREST/schema.graphqls -a Gateway/gateway.far
```
