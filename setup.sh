apt install openssh-server -q -y
sed '/PasswordAuthentication/d' /etc/ssh/sshd_config
echo "PasswordAuthentication no" >> /etc/ssh/sshd_config

apt install openjdk-17-jre -q -y
apt install screen -q -y

mkdir /srv/minecraft
adduser --system --no-create-home --home /srv/minecraft minecraft
chown minecraft:nogroup /srv/minecraft

cd /srv/minecraft
wget https://download.getbukkit.org/spigot/spigot-1.20.1.jar
su minecraft -c java -Xms2048M -Xmx4096M -jar spigot-1.20.1.jar nogui
sed '/eula/d' eula.txt
echo eula=true > eula.txt

su minecraft -c screen -S minecraft java -Xms2048M -Xmx4096M -jar spigot-1.20.1.jar nogui
