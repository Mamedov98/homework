

CREATE TABLE[dbo].[PRODUCT] (
    [Id]       INT IDENTITY(1, 1) NOT NULL,
    [Name]     NVARCHAR (30) NOT NULL,
    [Category] NVARCHAR (30) NOT NULL,
    [Colour]   NVARCHAR (30) NOT NULL,
    [Calories] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK([Calories] > (0))
);
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Cucumber', N'Vegetables', N'Green', 16)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Pineapple', N'Fruits', N'Brown', 86)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Mandarin', N'Fruits', N'Orange', 53)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Lemon', N'Fruits', N'Yellow', 29)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Radish', N'Vegetables', N'Red', 19)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Tomato', N'Vegetables', N'Red', 18)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Potato', N'Vegetables', N'Brown', 77)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Strawberry', N'Fruits', N'Red', 16)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Pepper', N'Vegetables', N'Red', 40)
insert into PRODUCT(Name, Category, Colour, Calories) values(N'Carrot', N'Vegetables', N'Orange', 41)

select* from PRODUCT order by Id