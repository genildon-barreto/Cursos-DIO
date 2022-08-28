#!/bin/bash

echo "Criando  diretórios..."
sudo mkdir /publico
sudo mkdir /adm
sudo mkdir /ven
sudo mkdir /sec
echo "Diretórios criados, iniciando próxima função 1/5"

echo "Criando grupos de usuários..."
sudo groupadd GRP_ADM
sudo groupadd GRP_VEN
sudo groupadd GRP_SEC
echo "Grupos de usuários criados, iniciando próxima função 2/5"

echo "Criando usuários..."
sudo useradd carlos -m -c "Carlos" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd carlos -e
sudo useradd maria -m -c "Maria" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd maria -e
sudo useradd joao -m -c "João" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd joao -e

sudo useradd debora -m -c "Débora" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd debora -e
sudo useradd sebastiana -m -c "Sebastiana" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd sebastiana -e
sudo useradd roberto -m -c "Roberto" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd roberto -e

sudo useradd josefa -m -c "Josefa" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd josefa -e
sudo useradd amanda -m -c "Amanda" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd amanda -e
sudo useradd rogerio -m -c "Rogério" -s /bin/bash -p $(openssl passwd Abc123)
sudo passwd rogerio -e
echo "Usuários adicionados, iniciando a próxima função 3/5"

echo "Adicionando usuários aos grupos..."
sudo gpasswd GRP_ADM -a carlos
sudo gpasswd GRP_ADM -a  maria
sudo gpasswd GRP_ADM -a  joao

sudo gpasswd GRP_VEN -a debora
sudo gpasswd GRP_VEN -a sebastiana
sudo gpasswd GRP_VEN -a roberto

sudo gpasswd GRP_SEC -a josefa
sudo gpasswd GRP_SEC -a amanda
sudo gpasswd GRP_SEC -a rogerio
echo "Usuários adicionados aos devidos grupos, iniciando a próxima função 4/5"

echo "Especificando permissões dos diretórios..."
sudo chown root:GRP_ADM /adm
sudo chown root:GRP_VEN /ven
sudo chown root:GRP_SEC /sec

sudo chmod 770 /adm
sudo chmod 770 /ven
sudo chmod 770 /sec
sudo chmod 777 /publico
echo "Permissões dos diretórios definidas, funções concluídas 5/5"

