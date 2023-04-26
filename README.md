<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="Web_Application_with_NBP_api_0"></a>Web Application with NBP api</h1>
<h3 class="code-line" data-line-start=3 data-line-end=4 ><a id="Uruchomienie_aplikacji_3"></a>Uruchomienie aplikacji</h3>
<ul>
<li class="has-line-data" data-line-start="4" data-line-end="5">Pobierz repozytorium za pomocą komendy</li>
</ul>
<pre><code class="has-line-data" data-line-start="6" data-line-end="8" class="language-sh">git <span class="hljs-built_in">clone</span> https://github.com/jogonowski297/NBP
</code></pre>
<ul>
<li class="has-line-data" data-line-start="8" data-line-end="9">Zaimportuj plik .tar jako Docker Image</li>
</ul>
<pre><code class="has-line-data" data-line-start="10" data-line-end="12" class="language-sh">docker load -i file_name.tar
</code></pre>
<ul>
<li class="has-line-data" data-line-start="12" data-line-end="13">Sprawdz czy pojawił się obraz o nazwie “nbp-image”</li>
</ul>
<pre><code class="has-line-data" data-line-start="14" data-line-end="16" class="language-sh">docker images
</code></pre>
<ul>
<li class="has-line-data" data-line-start="16" data-line-end="17">Uruchom aplikacje za pomocą polecenia (podaj własny port np. 8081)</li>
</ul>
<pre><code class="has-line-data" data-line-start="18" data-line-end="20" class="language-sh">docker run -p <span class="hljs-number">8081</span>:<span class="hljs-number">80</span> image_name
</code></pre>
<ul>
<li class="has-line-data" data-line-start="20" data-line-end="21">Uruchom przeglądarkę internetową i wklej link (pamiętaj o odpowiednim porcie)</li>
</ul>
<pre><code class="has-line-data" data-line-start="22" data-line-end="24" class="language-sh">http://localhost:<span class="hljs-number">8081</span>/home
</code></pre>
<h3 class="code-line" data-line-start=25 data-line-end=26 ><a id="Dziaanie_Aplikacji_25"></a>Działanie Aplikacji</h3>
<h1 class="code-line" data-line-start=26 data-line-end=27 ><a id="W_odpowiednie_pola_wpisz_potrzebne_informacje_26"></a>W odpowiednie pola wpisz potrzebne informacje:</h1>
<ul>
<li class="has-line-data" data-line-start="27" data-line-end="30">
<h5 class="code-line" data-line-start=27 data-line-end=28 ><a id="Pierwszy_formularz_CalculateAverageExchangeRate_27"></a>Pierwszy formularz CalculateAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="28" data-line-end="30">Kod: usd, Date 06.04.2023, Odpowiedź to:<br>
MID for 068/A/NBP/2023 : 4.3033</li>
</ul>
</li>
<li class="has-line-data" data-line-start="30" data-line-end="40">
<h5 class="code-line" data-line-start=30 data-line-end=31 ><a id="Drugi_formularz_MaxMinAverageExchangeRate_30"></a>Drugi formularz MaxMinAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="31" data-line-end="40">Kod: usd, Number: 6, Odpowiedź dzisiaj to:<br>
Min: 4.1557<br>
Max: 4.2244<br>
081/A/NBP/2023 : 4.1557<br>
080/A/NBP/2023 : 4.1649<br>
079/A/NBP/2023 : 4.1905<br>
078/A/NBP/2023 : 4.2006<br>
077/A/NBP/2023 : 4.2024<br>
076/A/NBP/2023 : 4.2244</li>
</ul>
</li>
<li class="has-line-data" data-line-start="40" data-line-end="44">
<h5 class="code-line" data-line-start=40 data-line-end=41 ><a id="Trzeci_formularz_BidAskRate_40"></a>Trzeci formularz BidAskRate</h5>
<ul>
<li class="has-line-data" data-line-start="41" data-line-end="44">Kod: usd, Number: 6, Odpowiedź dzisiaj to:<br>
-0,0839333333333333333333333333</li>
</ul>
</li>
</ul>
<h1 class="code-line" data-line-start=44 data-line-end=45 ><a id="Wprowad_bezporednio_link_44"></a>Wprowadź bezpośrednio link:</h1>
<ul>
<li class="has-line-data" data-line-start="45" data-line-end="51">
<h5 class="code-line" data-line-start=45 data-line-end=46 ><a id="Pierwszy_formularz_CalculateAverageExchangeRate_45"></a>Pierwszy formularz CalculateAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="46" data-line-end="51">Dla Kod: usd, Date 06.04.2023,<br>
Wklejamy odpowiadający link:<br>
<a href="https://localhost:8081/home/CalculateAverageExchangeRate/2023-04-06/usd">https://localhost:8081/home/CalculateAverageExchangeRate/2023-04-06/usd</a><br>
Odpowiedź to:<br>
MID for 068/A/NBP/2023 : 4.3033</li>
</ul>
</li>
<li class="has-line-data" data-line-start="51" data-line-end="64">
<h5 class="code-line" data-line-start=51 data-line-end=52 ><a id="Drugi_formularz_MaxMinAverageExchangeRate_51"></a>Drugi formularz MaxMinAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="52" data-line-end="64">Kod: usd, Number: 6,<br>
Wklejamy odpowiadający link:<br>
<a href="https://localhost:8081/home/MaxMinAverageExchangeRate/usd/6">https://localhost:8081/home/MaxMinAverageExchangeRate/usd/6</a><br>
Odpowiedź to:<br>
Min: 4.1557<br>
Max: 4.2244<br>
081/A/NBP/2023 : 4.1557<br>
080/A/NBP/2023 : 4.1649<br>
079/A/NBP/2023 : 4.1905<br>
078/A/NBP/2023 : 4.2006<br>
077/A/NBP/2023 : 4.2024<br>
076/A/NBP/2023 : 4.2244</li>
</ul>
</li>
<li class="has-line-data" data-line-start="64" data-line-end="70">
<h5 class="code-line" data-line-start=64 data-line-end=65 ><a id="Trzeci_formularz_BidAskRate_64"></a>Trzeci formularz BidAskRate</h5>
<ul>
<li class="has-line-data" data-line-start="65" data-line-end="70">Kod: usd, Number: 6,<br>
Wklejamy odpowiadający link:<br>
<a href="https://localhost:8081/home/BidAskRate/usd/6">https://localhost:8081/home/BidAskRate/usd/6</a><br>
Odpowiedź to:<br>
-0,0839333333333333333333333333</li>
</ul>
</li>
</ul>
