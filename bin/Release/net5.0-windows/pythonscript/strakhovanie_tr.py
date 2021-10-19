import numpy as np;
import pandas as pd;
import sys;
import os;

pd.set_option('display.float_format', '{:.12g}'.format);
np.set_printoptions(precision = 3, suppress= True);

df = pd.read_csv(os.getcwd() + '\data\data.csv', sep = ';');
df_price = pd.read_csv(os.getcwd() + r'\data\ar_price_data.csv', sep = ',');

# группировка марок авто
car_price = pd.Series(df_price['mean']);
car_price = pd.qcut(car_price, 3).to_frame().drop_duplicates().sort_values(by = 'mean');

econom = []; 
for i in range(df_price.shape[0]):
  if (df_price['mean'][i] in car_price['mean'][1]):
    econom.append(df_price['car'][i]);

middle = [];
for i in range(df_price.shape[0]):
  if (df_price['mean'][i] in car_price['mean'][0]):
    middle.append(df_price['car'][i]);

business = [];
for i in range(df_price.shape[0]):
  if (df_price['mean'][i] in car_price['mean'][7]):
    business.append(df_price['car'][i]);

# легкое ДТП
df_cut = df.drop(df[df['Легкое ДТП'] == 0].index);
df_l = pd.pivot_table(df_cut,
                            index = 'Марка автомобиля',
                            values = 'Выплата, руб.',
                            columns = 'Тип страхования',
                            aggfunc = np.mean
                           );
df_l.columns.name = None;
df_l = df_l.reset_index();
df_l = df_l.fillna(0); # сформирован исходный data set для обработки

s_l = []; # массив сумм
for i in range(3):
  s_l.append([0] * 2);
n = [0, 0, 0]; # массив количеств

for i in range(df_l.shape[0]):
  if (df_l['Марка автомобиля'][i] in econom):
    s_l[0][0] += df_l['полное'][i];
    s_l[0][1] += df_l['частичное'][i];
    n[0] += 1;
  elif (df_l['Марка автомобиля'][i] in middle):
    s_l[1][0] += df_l['полное'][i];
    s_l[1][1] += df_l['частичное'][i];
    n[1] += 1;
  else:
    s_l[2][0] += df_l['полное'][i];
    s_l[2][1] += df_l['частичное'][i];
    n[2] += 1;

# массив средних выплат для каждого класса авто по типам страхования
s_l[0][0] /= n[0]; # эконом + полное
s_l[0][1] /= n[0]; # эконом + частичное
s_l[1][0] /= n[1]; # средний + полное
s_l[1][1] /= n[1]; # средний + частичное
s_l[2][0] /= n[2]; # бизнес + полное
s_l[2][1] /= n[2]; # бизнес + частичное

# массив коэффициентов для мужчин и женщин по стажу вождения
df_kl = pd.read_csv(os.getcwd() + '\data\data_kl.csv', sep = ';');

# крупное ДТП
df_cut = df.drop(df[df['Крупное ДТП'] == 0].index);
df_k = pd.pivot_table(df_cut,
                            index = 'Марка автомобиля',
                            values = 'Выплата, руб.',
                            columns = 'Тип страхования',
                            aggfunc = np.mean
                           );
df_k.columns.name = None;
df_k = df_k.reset_index();
df_k = df_k.fillna(0);

s_k = [];
for i in range(3):
  s_k.append([0] * 2);
n = [0, 0, 0];

for i in range(df_k.shape[0]):
  if (df_k['Марка автомобиля'][i] in econom):
    s_k[0][0] += df_k['полное'][i];
    s_k[0][1] += df_k['частичное'][i];
    n[0] += 1;
  elif (df_k['Марка автомобиля'][i] in middle):
    s_k[1][0] += df_k['полное'][i];
    s_k[1][1] += df_k['частичное'][i];
    n[1] += 1;
  else:
    s_k[2][0] += df_k['полное'][i];
    s_k[2][1] += df_k['частичное'][i];
    n[2] += 1;

# массив средних выплат для каждого класса авто по типам страхования
s_k[0][0] /= n[0]; # эконом + полное
s_k[0][1] /= n[0]; # эконом + частичное
s_k[1][0] /= n[1]; # средний + полное
s_k[1][1] /= n[1]; # средний + частичное
s_k[2][0] /= n[2]; # бизнес + полное
s_k[2][1] /= n[2]; # бизнес + частичное

# массив коэффициентов для мужчин и женщин по стажу вождения
df_kk = pd.read_csv(os.getcwd() + '\data\data_kk.csv', sep = ';');

# угон, ДТП без восстановления авто
df_cut = df.drop(df[df['Угон, ДТП без востановления авто'] == 0].index);
df_u = pd.pivot_table(df_cut,
                            index = 'Марка автомобиля',
                            values = 'Выплата, руб.',
                            columns = 'Тип страхования',
                            aggfunc = np.mean
                           );
df_u.columns.name = None;
df_u = df_u.reset_index();
df_u = df_u.fillna(0);

s_u = [];
for i in range(3):
  s_u.append([0] * 1);
n = [0, 0, 0];

for i in range(df_u.shape[0]):
  if (df_u['Марка автомобиля'][i] in econom):
    s_u[0][0] += df_u['полное'][i];
    n[0] += 1;
  elif (df_u['Марка автомобиля'][i] in middle):
    s_u[1][0] += df_u['полное'][i];
    n[1] += 1;
  else:
    s_u[2][0] += df_u['полное'][i];
    n[2] += 1;

# массив средних выплат для каждого класса авто по типам страхования
s_u[0][0] /= n[0]; # эконом + полное
s_u[1][0] /= n[1]; # средний + полное
s_u[2][0] /= n[2]; # бизнес + полное

# матрица коэффициентов для мужчин и женщин по стажу вождения
df_ku = pd.read_csv(os.getcwd() + '\data\data_ku.csv', sep = ';');

# функция для подсчета стоимости страхования
def calculate(sex_, exp_, model_, tinsur_):

  p_l = df_kl[exp_][sex_] * df_kl['p_base'][sex_]; # exp (string) - строка-интервал, sex (int) - 0/1 (ж/м)
  m_l = s_l[model_][tinsur_]; # model (int) - 0/1/2 (econom/middle/business), tinsur (int) - 0/1 (п/ч)
  p_k = df_kk[exp_][sex_] * df_kk['p_base'][sex_];
  m_k = s_k[model_][tinsur_];
  p_u = df_ku[exp_][sex_] * df_ku['p_base'][sex_];
  if (tinsur_ == 0): # для угона, ДТП без восстановления авто доступен только полный тип страхования
    m_u = s_u[model_][tinsur_];
  else:
    m_u = 0;

  return (p_l*m_l + p_k*m_k + p_u*m_u);


sex = int(sys.argv[1]);
exp = str(sys.argv[2]);
model = int(sys.argv[3]);
tinsur = int(sys.argv[4]);

t = round(1.15 * calculate(sex, exp, model, tinsur), 2);

print(t);