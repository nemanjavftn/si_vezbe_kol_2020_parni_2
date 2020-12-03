﻿# si_vezbe_kol_2020_parni_2

Тип апликације: Windows– трослојна архитектура

-	Креирати базу података под називом CompanyDB и у оквиру ње направити табелу 
Employees са следећим колонама: 
Id int PK auto increment, 
Name nvarchar(50) NOT NULL, 
Surname nvarchar(50) NOT NULL, 
Salary decimal(18,0) NOT NULL  . (2 бодa)

-	Креирати слој који ће вршити конекцију на базу података (Data Layer) и где ће 
постојати један репозиторијум за комуникацију са креираном табелом у бази података 
(Employees). У оквиру репозиторијума треба да постоје методе: 
InsertEmployee 
(користи се за унос података у табелу Employees) и 
GetAllEmployees 
(за довлачење свих запослених из базе података). 
Што се тичSе модела, треба креирати модел-класe 
Person (Id, Name, Surname) и 
Employee која наслеђује Person и садржи још једно додатно поље Salary. (5 бодова)

-	Креирати слој у ком ће се налазити логика апликације и где ће у оквиру посебне 
business класе за рад са Employee вертикалом постојати две методе које преко Data слоја 
врше унос и довлачење запослених из репозиторијума. Метода која врши довлачење података 
треба да врати само запослене чија је плата у задатом рангу (од-до) са форме. (5 бодова)
-	На крају, направити .Net Windows Forms апликацију где ће се на почетној форми 
(текст форме на насловној линији: Zaposleni) вршити унос једног запосленог у базу података а у доњем делу форме ће се налазити један ListBox који приказује листу запослених (формат: <Id>. <Name> <Surname>). Поред ListBox-а треба да се налазе два TextBox поља за унос вредности плате (од-до) као и дугме на чији клик се извршава довлачење података. На сваки унос новог запосленог треба refresh-овати листу. (6 бодова)
Напомене: Користити лабеле поред контрола како би форма “имала смисла”. 
У моделима користити приватна поља и јавна својства (или аутосвојства).
