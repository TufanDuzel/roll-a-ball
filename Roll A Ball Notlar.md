- ROLL A BALL -

- GameObject ile oluşturulan zemin (plane), küre (sphere) gibi objelerin renkleri, bir material oluşturulup onlara verilir.

- RigidBody Compenent'i eklenerek, objeye yer çekimi ve fizik verilir.

- Script dosyası GameObject'e verilmelidir.

transform.Translate(x, y, z)
ile obje belirtilen değerlerde hareket ettirilir.

transform.Rotate(x, y, z)
ile obje belirtilen değerlerde döner.

Input
ile içerisinde bulunan birçok metod yardımıyla klavyeden girdi alma gibi işlemler yapılabilir.

Input.GetKeyDown()
ile tuşa basıldığında çalışır.
(KeyCode.) Parametresi
ile klavye tuşları algılanır.

Input.GetAxis()
ile parametre olarak horizontal veya vertical verilerek yön tuşları kullanıldığında çalıştırılır.

- Klavye girdisini Update()'de ama RigidBody, AddForce gibi fizik işlemlerini FixedUpdate()'de kullanılmalı.

- Fizik tabanlı hareketlerde Input ile alınan klavye girdisi ile RigidBody objesi tanımlanmalı ve vector ile obje hareket ettirilmeli. Aksi taktirde translate.Transform() kullanımında çarpma, yer çekimi gibi fizik hataları olur.

- Kodun en üstünde Rigidbody physic;  ile bir kez oluşturulur ve hafızaya atılır. Devamında Start() metodu içinde physic = GetComponent<Rigidbody>() ile o objenin Rigidbody compenent'i physic değişkenine bağlanır. Bu yöntem, Unity’nin bileşenlere erişme sistemini düzenli ve performans verimli kullanmak içindir.

physic.AddForce()
Objeye kuvvet uygulanmasını sağlar.

- Vector3 oluşturularak ve gerekli parametreler verilerek (x, y, z değerleri), devamında vector3 değişkeni AddForce()'a paremetre olarak verilebilir.

- Kamera takibi için eğer nesneye ait diğer verilere erişilmeyecekse, sadece position önemliyise Transform ile obje oluşturulabilir ve Unity'de top o complement'e verilir.

- Devamında main obje ve kamera arasındaki fark alınır ve main objeye eklenerek kameraya verilir. Bu sayede, main obje hareket ettikçe kamera aradaki fark kadar objeyi takip eder.

- Kamera işlemleri LateUpdate()'de yapılmalıdır.

- control + d tuşları ile seçilen obje kopyalanır.

- Box Collider, Unity'de bir nesnenin fiziksel sınırlarını belirlemek için kullanılan bir çarpışma kutusudur.

- Is Trigger eğer işaretlenirse, çarpışma fiziksel olmaz; sadece çarpma algılanır (örnek: bir objeyi toplayınca yok olması gibi)

- Destroy() metodu, Unity'de bir GameObject'i (veya bileşenini) sahneden yok etmek için kullanılır.
Destroy(other.gameObject);

- IsTrigger özelliği açık olan herhangi bir objeyle temasta onu yok eder.

- SetActive bir objede kaldırıldığında o objenin tüm complement'leri etkisiz olur, çalıştırılmaz.
gameObject.SetActive(false)

- GameObject panelinde UI ile ekranda text gibi objeler yapılır. UI objelerinin tamamı Canvas isimli objenin altında tanımlanmak zorundadır.

- EventSystem UI objesi oluşturulduğunda otomatik gelir. Diğer telefon gibi cihazlar için optimizasyon sağlar.

scoreText.text
ile scoreText değerinin metni değiştirilebilir.