# Software-Construction2024

1. **DRY (Don't Repeat Yourself)**:
   - Використання інтерфейсів для опису загальних властивостей (`IAnimal`, `IEmployee`, `IFood`)
   - дозволяє уникнути повторень коду.[Див. класи IAnimal,IEmployee,IFood](./Task1/Zoo/Program.cs#L7-L23)

2. **KISS (Keep It Simple, Stupid)**:
   - Чіткі та зрозумілі назви класів і методів спрощують розуміння коду.

3. **SOLID**:[Див. приклади використання SOLID]
   - **S (Принцип єдиної відповідальності)**: 
   - Кожен клас (`Animal`, `Employee`, `ZooInventory`, тощо) Наприклад, у класі ZooInventory відповідає за управління
   - списками тварин, співробітників і видів їжі в зоопарку. Це його основна відповідальність. Він має методи для додавання,
   - видалення, оновлення та відображення цих об'єктів. Якщо клас ZooInventory також почав би відповідати за інші аспекти,
   - наприклад, обробку фінансових операцій в зоопарку або взаємодію з іншими зоопарками, це порушило б принцип єдиної
   - відповідальності.[див.ZooInventory](./Task1/Zoo/ZooInventory.cs)
   - **O (Принцип відкритості/закритості)**: 
   - Код відкритий для розширення (додавання нових типів тварин, співробітників, їжі), але закритий для модифікації,
   - оскільки існуючі класи не потребують змін для додавання нового функціоналу.
   - **I (Принцип розділення інтерфейсу)**: 
   - Інтерфейси розділені для визначення конкретних наборів властивостей і поведінки.У коді принцип розділення інтерфейсу
   - використовується у вигляді використання інтерфейсів(`IAnimal`, `IEmployee`, `IFood`), які визначають конкретні набори
   - властивостей і поведінки для тварин, співробітників і їжі в зоопарку. Ці інтерфейси дозволяють створити загальні контракти
   - для об'єктів цих класів, що дозволяє легко взаємодіяти з ними та робити заміни об'єктів різних класів, які реалізують ці
   - інтерфейси, без необхідності змінювати код.
   - **D (Принцип інверсії залежностей)**: 
   - Залежність від абстракцій (`IAnimal`, `IEmployee`, `IFood`), у коді цей принцип використовується через використання
   - інтерфейсів IAnimal, IEmployee і IFood для представлення тварин, співробітників і видів їжі відповідно. Клас ZooInventory
   - залежить від цих абстракцій через параметри конструктора та методи додавання об'єктів. Це дозволяє легко замінювати
   - конкретні реалізації (`IAnimal`, `IEmployee`, `IFood`) на інші, не змінюючи клас ZooInventory, що відповідає принципу
   - інверсії залежностей.[Див.приклад](./Task1/Zoo/Program.cs#L7-L23)
4. **YAGNI (You Aren't Gonna Need It)**:
   - Реалізовано тільки потрібний функціонал, без зайвої складності.
5. **Composition Over Inheritance**:
   - Використання композиції для відносин між класами (`ZooInventory` містить списки тварин, співробітників і їжі) є більш
   - гнучким і уникне обмежень успадкування. [Див. клас ZooInventory](./Task1/Zoo/ZooInventory.cs#L17-L22)
6. **Program to Interfaces, not Implementations**:
   - Програмування до інтерфейсів (`IAnimal`, `IEmployee`, `IFood`) спрощує тестування і зберігання, оскільки
   - код працює з абстракціями, а не з конкретними класами.[interfaces](./Task1/Zoo/Program.cs#L7-L23)

