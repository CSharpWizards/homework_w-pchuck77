1. Открой `AttackCalculator`. Представь, что ты пишешь игру, где есть противник, сила атаки которого пропорциональна его здоровью. То есть, например, если его здоровье упало до половины от изначального, то и атаковать он будет в пол силы от изначального урона. Напиши код функции `GetReducedAttack`, которая принимает параметрами текущее здоровье (health), изначальное здоровье (maxHealth) и изначальную силу атаки (maxAttack). Функция вычисляет и возвращает обновленную силу атаки

2. У героя нет ничего, кроме верного коня. Даже меча, и того нет! Но он мечтает о подвигах. После долгих дней странствий наткнулся он на заброшенную деревушку. Злобный Великан повадился от скуки крушить и ломать дома крестьян, красть скот, вытаптывать поля. Напиши нелинейный квест о приключениях героя

   Каждая локация оформлена в свою функцию. Каждое действие тоже рекомендуется вынести в свою функцию. Для выбора локации тоже должна быть создана отдельная функция

   Не забудь объявить свойства (здоровье, атаку, деньги, наличие коня и тд) статическими, чтобы они были доступны из твоих статических функций

   Локации:

   1. Зеленые поля. Отсюда ты стартуешь. Здесь доступны лишь 2 действия: выбрать локацию или услышать историю Хранителя Поля (Какие-то подробности о мире, его обитателях и тд. Выбирается случайно из предзаготовленного массива)
   2. Лавка Торговца. Доступны 4 действия: 
      - Выбрать локацию
      - Продать коня (проверь, что коня нельзя продать дважды)
      - Купить меч (увеличивает атаку) или доспехи (увеличивают атаку). Что именно предлагает торговец, выбирается с помощью случайного числа. Денег от продажи коня хватит только на что-то одно
      - Прослушать историю (О торговле, знакомых, биографии торговца и тд. Выбирается случайно из предзаготовленного массива)
      - (не обязательно) Купить аптечку. В этом случае стоит сделать, чтобы здоровье бандитов восстанавливалось при выходе из леса
   3. Лес. Здесь живут разбойники. Доступны 2 действия: выбрать локацию и атаковать разбойников
      - Разбойники атакуют сразу, как ты вошел в лес, так же они атакуют после каждой твоей атаки. Подбери свои и разбойников показатели (здоровье и атаку) так, чтобы ты проигрывал, если у тебя пока нет ни меча, ни брони
        - После каждой атаки заново предлагается диалог выбора действий
      - Для расчета актуальной силы атаки разбойников используй функцию `GetReducedAttack` из прошлой задачи, чтобы раненые противники атаковали слабее
      - Если твое здоровье падает до нуля, то ты проигрываешь. При проигрыше предлагается начать заново или закончить игру
      - Если здоровье разбойников падает до нуля, то твое здоровье восстанавливается и прибавляется бонусное здоровье
   4. Деревня. Здесь терроризирует местных жителей великан. Доступны 2 действия: выбрать локацию и атаковать великана
      - Великан атакует сразу, как ты вошел в деревню, так же он атакует после каждой твоей атаки. Подбери свои и великана показатели так, чтобы ты проигрывал, если ты пока не получил бонус от разбойников
        - После каждой атаки заново предлагается диалог выбора действий
      - Для расчета актуальной силы атаки великана используй функцию `GetReducedAttack` из прошлой задачи, чтобы раненые противники атаковали слабее
      - Если твое здоровье падает до нуля, то ты проигрываешь. При проигрыше предлагается начать заново или закончить игру
      - Если здоровье великана падает до нуля, то ты выигрываешь

