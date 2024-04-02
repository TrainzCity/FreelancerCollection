apt install openssh-server -q -y
sed '/PasswordAuthentication/d' /etc/ssh/sshd_config
echo "PasswordAuthentication no" >> /etc/ssh/sshd_config

apt install default-jre-headless -qq
apt install screen -qq

mkdir /srv/minecraft
adduser --system --no-create-home --home /srv/minecraft minecraft
chown minecraft:minecraft /srv/minecraft

cd /srv/minecraft
wget https://download.getbukkit.org/spigot/spigot-1.20.1.jar
su -u minecraft -c java -Xms2048M -Xmx4096M -jar spigot-1.20.1.jar nogui
sed '/eula/d' eula.txt
echo eula=true > eula.txt

su -u minecraft -c screen -S minecraft java -Xms2048M -Xmx4096M -jar spigot-1.20.1.jar nogui