<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="Web_Application_with_NBP_api_0"></a>Web Application with NBP api</h1>
<h3 class="code-line" data-line-start=3 data-line-end=4 ><a id="Running_the_Application_3"></a>Running the Application</h3>
<ul>
<li class="has-line-data" data-line-start="4" data-line-end="5">Download the repository using the command</li>
</ul>
<pre><code class="has-line-data" data-line-start="6" data-line-end="8" class="language-sh">git <span class="hljs-built_in">clone</span> https://github.com/jogonowski297/NBP
</code></pre>
<ul>
<li class="has-line-data" data-line-start="8" data-line-end="9">Download file with dockerimage</li>
</ul>
<pre><code class="has-line-data" data-line-start="10" data-line-end="12" class="language-sh">https://drive.google.com/file/d/<span class="hljs-number">1</span>WEfTSZiShR7JXVL9tBGteW7E-vtLRXv2/view?usp=sharing
</code></pre>
<ul>
<li class="has-line-data" data-line-start="12" data-line-end="13">Import the .tar file as a Docker Image</li>
</ul>
<pre><code class="has-line-data" data-line-start="14" data-line-end="16" class="language-sh">docker load -i nbp-image.tar
</code></pre>
<ul>
<li class="has-line-data" data-line-start="16" data-line-end="17">Check if an image named “nbp-image” has appeared</li>
</ul>
<pre><code class="has-line-data" data-line-start="18" data-line-end="20" class="language-sh">docker images
</code></pre>
<ul>
<li class="has-line-data" data-line-start="20" data-line-end="21">Run the application using the command (provide your own port, e.g. 8081)</li>
</ul>
<pre><code class="has-line-data" data-line-start="22" data-line-end="24" class="language-sh">docker run -p <span class="hljs-number">8081</span>:<span class="hljs-number">80</span> nbp-image
</code></pre>
<ul>
<li class="has-line-data" data-line-start="24" data-line-end="25">Open a web browser and paste the link (remember to use the correct port)</li>
</ul>
<pre><code class="has-line-data" data-line-start="26" data-line-end="28" class="language-sh">http://localhost:<span class="hljs-number">8081</span>/home
</code></pre>
<h3 class="code-line" data-line-start=29 data-line-end=30 ><a id="Application_Functionality_29"></a>Application Functionality</h3>
<h1 class="code-line" data-line-start=30 data-line-end=31 ><a id="Fill_in_the_required_information_in_the_appropriate_fields_30"></a>Fill in the required information in the appropriate fields:</h1>
<ul>
<li class="has-line-data" data-line-start="31" data-line-end="34">
<h5 class="code-line" data-line-start=31 data-line-end=32 ><a id="First_form_CalculateAverageExchangeRate_31"></a>First form CalculateAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="32" data-line-end="34">For: usd, Date 06.04.2023, The response is:<br>
MID for 068/A/NBP/2023 : 4.3033</li>
</ul>
</li>
<li class="has-line-data" data-line-start="34" data-line-end="44">
<h5 class="code-line" data-line-start=34 data-line-end=35 ><a id="Second_form_MaxMinAverageExchangeRate_34"></a>Second form MaxMinAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="35" data-line-end="44">Kod: usd, Number: 6, The response is:<br>
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
<li class="has-line-data" data-line-start="44" data-line-end="48">
<h5 class="code-line" data-line-start=44 data-line-end=45 ><a id="Third_form_BidAskRate_44"></a>Third form BidAskRate</h5>
<ul>
<li class="has-line-data" data-line-start="45" data-line-end="48">Kod: usd, Number: 6, The response is:<br>
-0,0839333333333333333333333333</li>
</ul>
</li>
</ul>
<h1 class="code-line" data-line-start=48 data-line-end=49 ><a id="Enter_the_link_directly_48"></a>Enter the link directly:</h1>
<ul>
<li class="has-line-data" data-line-start="49" data-line-end="55">
<h5 class="code-line" data-line-start=49 data-line-end=50 ><a id="First_form_CalculateAverageExchangeRate_49"></a>First form CalculateAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="50" data-line-end="55">For Kod: usd, Date 06.04.2023,<br>
Wklejamy odpowiadający link:<br>
<a href="https://localhost:8081/home/CalculateAverageExchangeRate/2023-04-06/usd">https://localhost:8081/home/CalculateAverageExchangeRate/2023-04-06/usd</a><br>
The response is:<br>
MID for 068/A/NBP/2023 : 4.3033</li>
</ul>
</li>
<li class="has-line-data" data-line-start="55" data-line-end="68">
<h5 class="code-line" data-line-start=55 data-line-end=56 ><a id="Second_form_MaxMinAverageExchangeRate_55"></a>Second form MaxMinAverageExchangeRate</h5>
<ul>
<li class="has-line-data" data-line-start="56" data-line-end="68">Kod: usd, Number: 6,<br>
Wklejamy odpowiadający link:<br>
<a href="https://localhost:8081/home/MaxMinAverageExchangeRate/usd/6">https://localhost:8081/home/MaxMinAverageExchangeRate/usd/6</a><br>
The response is:<br>
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
<li class="has-line-data" data-line-start="68" data-line-end="74">
<h5 class="code-line" data-line-start=68 data-line-end=69 ><a id="Third_form_BidAskRate_68"></a>Third form BidAskRate</h5>
<ul>
<li class="has-line-data" data-line-start="69" data-line-end="74">Kod: usd, Number: 6,<br>
Wklejamy odpowiadający link:<br>
<a href="https://localhost:8081/home/BidAskRate/usd/6">https://localhost:8081/home/BidAskRate/usd/6</a><br>
The response is:<br>
-0,0839333333333333333333333333</li>
</ul>
</li>
</ul>
