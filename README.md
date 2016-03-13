[![Build status](https://ci.appveyor.com/api/projects/status/8m4sobfiey94wqmo/branch/master?svg=true)](https://ci.appveyor.com/project/vors/assignment2/branch/master)

# Assignment2
Основы С# и Visual Studio

Цель занятия -- познакомиться с нашими основными инструментами разработки.
Начиная с этого занятия, мы будем использовать полученные знания о работе с `git`

* вы клонируете себе репозиторий урока с помощью `git clone`
* в процессе занятия и после, вы пушайте изменения в свой форк.
* когда они готовы, вы посылаете Pull Request в основной репозиторий

## Установка Visual Studio

Если у вас нет VS 2015, вы можете установить ее с сайта https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx

## План занятия

* Разобрать базовый интерфейс Visual Studio
  - открытие
  - запуск
  - дебаг
  - go to definition
* Разобрать базовай синтаксис C#
  - `var`
  - `class` + `interface`
  - `out`

## Задание

 Написать имплементацию метода `FibonacciGenerator.Get(int n)` и отправить pull request в https://github.com/vors/Assignment2
 с вашим решением.
 Проверка по PR.
 
 Замечание: PR не будет замержен, чтобы избежать конфликтов с другими студентами.

# Assignment3

Тестирование и билд-сервер.


## План занятия

Концептуально:

* Tests
* CI (Continious Integration)

Конкретно:

* Visual Studio Unit tests
* [AppVeyor](https://ci.appveyor.com/project/vors/assignment2)

## Заданиe
Обновить PR, добившись чтобы все тесты проходили
