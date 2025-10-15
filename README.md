# Część I. Aplikacja konsolowa  
Napisz program sortujący tablicę metodą przez wybieranie według zamieszczonej dokumentacji: 
Sortowanie przez wybieranie- jedna z prostszych metod sortowania o złożoności O(n2). Polega na wyszukaniu elementu mającego się znaleźć na żądanej pozycji i zamianę z elementem na tej pozycji. Operacja jest wykonywana dla wszystkich indeksów sortowanej tablicy. 
 
## Algorytm przedstawia się następująco: 
- wyszukaj minimalną wartość z tablicy spośród elementów od i do końca tablicy 
- Wstaw wartość minimalną na pozycji i 
- Wartość z pozycji i wstaw na pozycję znalezionego elementu o minimalnej wartości 
- Gdy zamiast wartości minimalnej wybierana będzie maksymalna, wówczas tablica będzie posortowana od największego do najmniejszego elementu. 
 
## Założenia do programu: 
- Sortowanie odbywa się malejąco, nie wykorzystuje gotowych funkcji do sortowania oraz do szukania maksimum. 
- Sortowana jest tablica N liczb całkowitych, N jest podawane jako wartość do konstruktora, domyślnie przyjmij 50 
- Tablica jest polem klasy. 
- Elementy tablicy są losowane, wartości maja być liczbami całkowitymi z przedziału [0,100] . 
- Wszystkie elementy nieposortowanej i posortowanej tablicy są wyświetlane na ekranie. 
- Klasa zawiera co najmniej dwie metody: sortującą i szukającą wartość najwyższą. 
- Widzialność metody szukającej ogranicza się jedynie do klasy. 
- Metoda szukająca zwraca wartość, w zależności od przyjętej taktyki może być to wartość maksymalna lub index wartości maksymalnej. 
- Program powinien być zapisany czytelnie, z zasadami czystego formatowania kodu, należy stosować znaczące nazwy zmiennych i funkcji. 

Dokumentację aplikacji należy utworzyć zgodnie z opisem w części III treści zadania. 
